using Lesson7Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // has a (aggregation | composition | assosation)
        // use a dependency
        // is a  inheritance
        // can do interface
        // generalization
        // realization


        IMusician musician = new User();
        musician.Play();
        musician.Stop();

        
    }
}