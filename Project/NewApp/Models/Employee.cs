namespace NewApp.Models
{
    public class Employee
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int Age { get; set; }
        public int Luong { get; set; }
        public void NhapTT()
        {
            System.Console.Write("Ma nhan vien: ");
            MaNV = Console.ReadLine();
            System.Console.Write("Ten nhan vien: ");
            TenNV = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Age = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Luong: ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThiTT()
        {
            System.Console.WriteLine("Ma nhan vien: ", MaNV);
            System.Console.WriteLine("Ten nhan vien: ", TenNV);
            System.Console.WriteLine("Tuoi: ", Age);
            System.Console.WriteLine("Luong: ", Luong);
        }
    }
}