# Simple Twitter Bot

To use:
1. Go to Twitter Developer Portal (https://developer.twitter.com/)
2. Start a new project/app
3. Request Elevated status for your project
4. Set up OAuth 1.0 or 2.0 (callback url is not important for this bot in it's current state)
5. Take note of your app's API Key, API Key Secret, Access Token, and Access Token Secret
6. Store these keys/tokens as variables directly in you C# program as a string variable, or as environment varables to be read from the launchSettings.json file
7. Add your desired image to "<project folder>/bin/Debug/net5.0/" and change the .jpg file in in the imageBytes array
8. In the ITweet object, change the PublishTweetParameters string to your desired message
