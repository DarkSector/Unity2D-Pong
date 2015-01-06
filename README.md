#Unity Pong

I have wanted to learn Unity2D for ever. Now, I finally got around to doing it. I followed the tutorial listed here http://www.awesomeincu.com/tutorials/unity-pong/

I did make some changes though. Some of the things in the tutorial didn't work for me. 
Here are the differences between what I did and what the guide showed.
 * In the method https://github.com/DarkSector/Unity2D-Pong/blob/master/Assets/_Scripts/SideWalls.cs#L6 I renamed it to OnCollisionEnter2D instead of 
OnTrigger ... 
 * In the same location I used Transform.name 
 * I used Invoke instead of hi() as shown here https://github.com/DarkSector/Unity2D-Pong/blob/master/Assets/_Scripts/BallControl.cs#L8

##Credits
 * Background Audio by [Chris Zabriskie](http://freemusicarchive.org/music/Chris_Zabriskie/Direct_to_Video_1014/07_-_Its_Always_Too_Late_to_Start_Over)
 * Background Image from FTL
