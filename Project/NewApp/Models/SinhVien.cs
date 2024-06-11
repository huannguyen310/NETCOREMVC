using NewApp.Models;
public class SinhVien
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public string DiaChi { get; set; }
    public string SoDT { get; set; }
    public void Nhap()
    {
        System.Console.Write("Ho ten: ");
        HoTen = Console.ReadLine();
        System.Console.Write("Tuoi: ");
        Tuoi = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Dia chi: ");
        DiaChi = Console.ReadLine();
        System.Console.Write("So dien thoai: ");
        SoDT = Console.ReadLine();
    }
    public void HienThi()
    {
        System.Console.WriteLine("{0} - {1} - {2} - {3}", HoTen, Tuoi, DiaChi, SoDT);
    }
}