using System;
using System.IO;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using System.Threading.Tasks;

namespace TomsBot1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = System.Environment.GetEnvironmentVariable("apiKey");
            string apiKeySecret = System.Environment.GetEnvironmentVariable("apiKeySecret");
            string accessToken = System.Environment.GetEnvironmentVariable("accessToken");
            string accessTokenSecret = System.Environment.GetEnvironmentVariable("accessTokenSecret");
            byte[] imageBytes = File.ReadAllBytes("banner2.jpg");
            TwitterClient UserClient = new TwitterClient(apiKey, apiKeySecret, accessToken, accessTokenSecret);
            IMedia imageIMedia = await UserClient.Upload.UploadTweetImageAsync(imageBytes);
            ITweet tweetWithImage = await UserClient.Tweets.PublishTweetAsync(
                new PublishTweetParameters("This Tweet was brought to you by the Bot that Tom just made.  Fuck Yeah!") { Medias = { imageIMedia }});
        }
    }
}
