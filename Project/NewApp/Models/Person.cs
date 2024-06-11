namespace NewApp.Models
{
    public class Person
    {
        public string PSName { get; set; }
        public string PersonID { get; set; }
        public int Age { get; set; }
        public string DiaChi { get; set; }
        public void NhapTT()
        {
            System.Console.Write("Nhap ten: ");
            PSName = Console.ReadLine();
            System.Console.Write("So dinh danh: ");
            PersonID = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Age = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
        }
        public void HienThiTT()
        {
            System.Console.WriteLine("{0} - {1} - {2} - {3}", PSName, PersonID, Age, DiaChi);
        }
    }
}