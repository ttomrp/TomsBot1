# Simple Twitter Bot

To use:
1. Go to Twitter Developer Portal (https://developer.twitter.com/)
2. Start a new project/app
3. Request Elevated status for your project
4. Take note of your app's API Key, API Key Secret, Access Token, and Access Token Secret
5. Store these keys/tokens as variables directly in you C# program as a string variable, or as environment varables to be read from the launchSettings.json file
6. Add your desired image to "<project folder>/bin/Debug/net5.0/" and change the .jpg file in in the imageBytes array
7. In the ITweet object, change the PublishTweetParameters string to your desired message
