using System;
using SlackCleanup.SlackApiImplementation;
using SlackCleanup.SlackApiImplementation.Model.Requests;

namespace Worker
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Are you sure you want to continue? This will delete all your slack files [Y/N]");
            var key = Console.ReadLine();
            if (key != "Y" && key != "N")
            {
                Console.WriteLine("Value does not match options. Your options are Y / N");
                Console.WriteLine("Exiting ... ");
                return;
            }

            if (key == "N")
            {
                Console.WriteLine("You chose not to continue");
                Console.WriteLine("Exiting ... ");
                return;
            }

            Console.WriteLine("Paste your slack api key please.");
            Console.WriteLine("Your api key can be obtained by requesting a token with the legacy token generator");
            
            //https://api.slack.com/custom-integrations/legacy-tokens
            System.Diagnostics.Process.Start(@"https://api.slack.com/custom-integrations/legacy-tokens");

            var apiKey = Console.ReadLine();
            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("You didn't paste anything");
                Console.WriteLine("Exiting ... ");
                return;
            }

            var slackApi = SlackApi.Create(apiKey);
            var whoAmI = slackApi.Auth.Test();
            if (!whoAmI.Ok)
            {
                Console.WriteLine("Api key you passed does not work");
                Console.WriteLine("Exiting ... ");
                return;
            }

            Console.WriteLine("You are: {0}. Continue deleting your files? [Y/N]", whoAmI.User);

            key = Console.ReadLine();
            if (key != "Y" && key != "N")
            {
                Console.WriteLine("Value does not match options. Your options are Y / N");
                Console.WriteLine("Exiting ... ");
                return;
            }

            if (key == "N")
            {
                Console.WriteLine("You chose not to continue");
                Console.WriteLine("Exiting ... ");
                return;
            }

            var myfiles = slackApi.Files.List(new FilesListRequest
            {
                User = whoAmI.UserId,
            });

            if (!myfiles.Ok)
            {
                Console.WriteLine("Could not access you files list");
                Console.WriteLine("Exiting ... ");
                return;
            }

            if (myfiles.Files.Count == 0)
            {
                Console.WriteLine("You don't have any files");
            }

            else
            {
                Console.WriteLine("You have {0} files. Proceed deleting them", myfiles.Files.Count);

                var error = 0;

                foreach (var file in myfiles.Files)
                {
                    Console.WriteLine("Deleting {0}", file.Name);
                    try
                    {
                        slackApi.Files.Delete(file.Id);
                    }
                    catch
                    {
                        error++;
                    }
                }

                if (error == 0)
                {
                    Console.WriteLine("All your files were erased");
                }
                else
                {
                    var remainingFiles = slackApi.Files.List(new FilesListRequest
                    {
                        User = whoAmI.UserId,
                    });

                    Console.WriteLine("Some files could not be removed:");
                    if (remainingFiles.Ok)
                    {
                        foreach (var file in remainingFiles.Files)
                        {
                            Console.WriteLine(file.Name);
                        }
                    }
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
