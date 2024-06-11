namespace NewApp.Models
{
    public class Fruit
    {
        public string Name { get; set; }
        public string MauSac { get; set; }
        public void NhapTT()
        {
            System.Console.Write("Ten qua: ");
            Name = Console.ReadLine();
            System.Console.Write("Mau qua: ");
            MauSac = Console.ReadLine();
        }
        public void HienThiTT()
        {
            System.Console.WriteLine("Qua: ", Name);
            System.Console.WriteLine("Mau: ", MauSac);
        }
    }
}