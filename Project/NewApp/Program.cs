using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        Person ps1 = new Person();
        ps1.NhapTT();
        ps1.HienThiTT();
        SinhVien SV1 = new SinhVien();
        SV1.Nhap();
        SV1.HienThi();
        Employee epl1 = new Employee();
        epl1.NhapTT();
        epl1.HienThiTT();
        Student std = new Student();
        std.NhapTT();
        std.HienThiTT();
        Fruit fr1 = new Fruit();
        fr1.NhapTT();
        fr1.HienThiTT();
    }
}