namespace H_W_21._10._23
{
    internal class Song
    {
        private string name;
        private string author;
        private Song prev;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Song Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }

        public string Title()
        {
            return name + " by " + author;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song otherSong = (Song)obj;
            return this.name == otherSong.name && this.author == otherSong.author;
        }

    }
}
