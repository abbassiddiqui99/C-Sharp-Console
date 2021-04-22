namespace C_Sharp_Console
{
    public class StaticAttributes
    {
        // This Code is a reference of static attributes and explanation.
        public string Song_Name;
        public string Artist;
        public int Duration;
        // You Can't Access this static attribute with object
        // Can Access only using ClassName.songCount === StaticAttributes.songCount
        public static int songCount = 0;
        // public static int MyProperty { get; set; } = 0;


        public StaticAttributes(string aSong_Name, string aArtist, int aDuration) {
            Song_Name = aSong_Name;
            Artist = aArtist;
            Duration = aDuration;
            songCount++;
        }

        // if you wanna access static attributes using object you can make function like this
        public int getStaticAttribute(){
            return songCount;
        }
    }
}