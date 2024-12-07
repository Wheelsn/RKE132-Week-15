List<Movie> mymovies = new List<Movie>();
string[] data = GetDataFromFile();

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie movie = new Movie(tempArray[0], tempArray[2]);
    mymovies.Add(movie);
}

foreach (Movie movie in mymovies)
{
    Console.WriteLine($"One of my favourtite movies {movie.Title} was released in {movie.Year}. ");
}

static string[] GetDataFromFile()
{
    string filePath = @"C:\data\movies.txt";
    return File.ReadAllLines(filePath);
}

class Movie
{
    string title; //fields
    string year;

    public string Title //properties
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year) //constructor
    {
        this.title = _title;
        this.year = _year;
    }

}