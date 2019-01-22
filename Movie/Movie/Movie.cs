using System;
namespace Movie
{
    public class Movie
    {
        public Movie(string name, Rating rating, Genre genre)
        {
            Name = name;
            Rating = rating;
            Genre = genre;
        }

        public String Name { get; set; }
        public Rating Rating { get; set; }
        public Genre Genre { get; set; }


    public override bool Equals(Object obj)
        {
            if (this == obj) return true;
            if (!(obj is Movie)) return false;
            Movie movie = (Movie)obj;
            return Name == movie.Name &&
                   Rating == movie.Rating &&
                   Genre == movie.Genre;
        }


    public override int GetHashCode()
        {
            int result = (Name != null ? Name.GetHashCode() : 0);
            result = (result * 397) ^ Rating.GetHashCode();
            result = (result * 397) ^ Genre.GetHashCode();
            return result;
        }


    public override String ToString()
        {
            return "Movie{" +
                    "name='" + Name + '\'' +
                    ", rating=" + Rating +
                    ", genre=" + Genre +
                    '}';
        }
    }
}
