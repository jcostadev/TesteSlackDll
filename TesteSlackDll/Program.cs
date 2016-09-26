using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slack.Webhooks;

namespace TesteSlackDll {
    class Program {
        static void Main(string[] args) 
        {
            var slackClient = new SlackClient("https://hooks.slack.com/services/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");

            var slackMessage = new SlackMessage
            {
                Channel = "#teste",
                Text = "My message",
                IconEmoji = Emoji.School,
                Username = "nerdfury"
            };

            var slackAttachment = new SlackAttachment {

                Fallback = "ReferenceError - UI is not defined: https://honeybadger.io/path/to/event/",
                Text = "<https://honeybadger.io/path/to/event/|ReferenceError> - UI is not defined",

                Fields =
                    new List<SlackField>
                    {
                        new SlackField
                        {
                            Title = "Project",
                            Value =  "Awesome Project",
                            Short = true
                        },

                        new SlackField
                        {
                            Title = "Environment",
                            Value = "production",
                            Short = true
                        },

                    },

                Color = "#F35A00"
            };


            /*var slackAttachment = new SlackAttachment
            {

                Fallback = "Required plain-text summary of the attachment.",
                Color = "#36a64f",
                Pretext = "Optional text that appears above the attachment block",
                AuthorName = "Bobby Tables",
                AuthorLink = "http://flickr.com/bobby/",
                AuthorIcon = "http://flickr.com/icons/bobby.jpg",
                Title = "Slack API Documentation",
                TitleLink = "https://api.slack.com/",
                Text = "Optional text that appears within the attachment",
                Fields =
                    new List<SlackField>
                    {
                        new SlackField
                        {
                            Title = "Priority",
                            Value = "High",
                            Short = false
                        }

                    }
            };*/


            /*  Fallback = "New open task [Urgent]: <http://url_to_task|Test out Slack message attachments>",
            Text = "New open task *[Urgent]*: <http://url_to_task|Test out Slack message attachments>",
            Color = "#D00000",
            Fields =
        new List<SlackField>
            {
                new SlackField
                    {
                        Title = "Notes",
                        Value = "This is much *easier* than I thought it would be."
                    }
            }
        };*/

            /*var slackMessage = new SlackMessage
           {
               //Text = "~*My message*~ "

               Text = ":zero:"
           };*/

            /*var slackMessage = new SlackMessage {

                Text = ":swimmer:",
                //Channel = "#hi"
                Username = "testbot",
                IconEmoji = ":swimmer:"//Emoji.Sushi
            };*/


            slackMessage.Attachments = new List<SlackAttachment> { slackAttachment };

            slackClient.Post(slackMessage);

            Console.ReadLine();
        }
    }
}
