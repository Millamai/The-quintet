namespace The_quintet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Violin violin = new Violin(6);
            Console.WriteLine(violin.ToString());
            violin.Play();


            Saxophone sax = new Saxophone();
            Console.WriteLine(sax.ToString());
            sax.Play();

            Guitar gui = new Guitar(6);
            Console.WriteLine(gui.ToString());
            gui.Play();

            Drum drum = new Drum();
            Console.WriteLine(drum.ToString());
            drum.Play();

            Piano pi = new Piano(88);
            Console.WriteLine(pi.ToString());
            pi.Play();
        }
    }
}
