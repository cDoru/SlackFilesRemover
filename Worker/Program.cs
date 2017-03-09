using System;
using System.Diagnostics;
using System.Drawing;
using SlackCleanup.SlackApiImplementation;
using SlackCleanup.SlackApiImplementation.Model.Requests;
using Console = Colorful.Console;

namespace Worker
{
    class Program
    {
        const string LegacyTokenGeneratorUrl = "https://api.slack.com/custom-integrations/legacy-tokens";
        private static void Main(string[] args)
        {
            Console.WriteLine("Are you sure you want to continue? This will delete all your slack files [Y/N]", Color.Green);
            var key = Console.ReadLine();
            if (key != "Y" && key != "N")
            {
                Console.WriteLine("Value does not match options. Your options are Y / N", Color.Red);
                Console.WriteLine("Press any key to exit...", Color.Red);
                Console.ReadKey();
                return;
            }

            if (key == "N")
            {
                Console.WriteLine("You chose not to continue", Color.Red);
                Console.WriteLine("Press any key to exit...", Color.Red);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Paste your slack api key please.", Color.Green);
            Console.WriteLine("Your api key can be obtained by requesting a token with the legacy token generator", Color.Yellow);
            
            Process.Start(LegacyTokenGeneratorUrl);

            var apiKey = Console.ReadLine();
            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("You didn't paste anything", Color.Red);
                Console.WriteLine("Press any key to exit... ", Color.Red);
                Console.ReadKey();
                return;
            }

            var slackApi = SlackApi.Create(apiKey);
            var whoAmI = slackApi.Auth.Test();
            if (!whoAmI.Ok)
            {
                Console.WriteLine("Api key you passed does not work", Color.Red);
                Console.WriteLine("Press any key to exit...", Color.Red);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("You are: {0}. Continue deleting your files? [Y/N]", whoAmI.User, Color.Green);

            key = Console.ReadLine();
            if (key != "Y" && key != "N")
            {
                Console.WriteLine("Value does not match options. Your options are Y / N", Color.Red);
                Console.WriteLine("Press any key to exit...", Color.Red);
                Console.ReadKey();
                return;
            }

            if (key == "N")
            {
                Console.WriteLine("You chose not to continue", Color.Red);
                Console.WriteLine("Press any key to exit... ", Color.Red);
                Console.ReadKey();
                return;
            }

            var myfiles = slackApi.Files.List(new FilesListRequest
            {
                User = whoAmI.UserId,
            });

            if (!myfiles.Ok)
            {
                Console.WriteLine("Could not access you files list", Color.Red);
                Console.WriteLine("Press any key to exit...", Color.Red);
                Console.ReadKey();
                return;
            }

            if (myfiles.Files.Count == 0)
            {
                Console.WriteLine("You don't have any files", Color.Green);
            }

            else
            {
                Console.WriteLine("You have {0} files. Proceed deleting them", myfiles.Files.Count, Color.Yellow);

                var error = 0;

                foreach (var file in myfiles.Files)
                {
                    Console.WriteLine("Deleting {0}", file.Name, Color.Green);
                    try
                    {
                        slackApi.Files.Delete(file.Id);
                    }
                    catch
                    {
                        Console.WriteLine("Could not delete {0}", file.Name, Color.Red);
                        error++;
                    }
                }

                if (error == 0)
                {
                    Console.WriteLine("All your files were erased", Color.Green);
                }
                else
                {
                    var remainingFiles = slackApi.Files.List(new FilesListRequest
                    {
                        User = whoAmI.UserId,
                    });

                    Console.WriteLine("Some files could not be removed:", Color.Red);
                    if (remainingFiles.Ok)
                    {
                        foreach (var file in remainingFiles.Files)
                        {
                            Console.WriteLine(file.Name, Color.Red);
                        }
                    }
                }
            }

            Console.WriteLine("Press any key to exit...", Color.Yellow);
            Console.ReadKey();
        }
    }
}
