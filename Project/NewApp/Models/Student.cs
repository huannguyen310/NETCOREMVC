namespace NewApp.Models
{
    public class Student
    {
        public string StudentName {get; set; }
        public string StudentID { get; set; }
        public int MaSV { get; set; }
        public string Address { get; set; }
        public void NhapTT()
        {
            System.Console.Write("Ten sinh vien: ");
            StudentName = Console.ReadLine();
            System.Console.Write("ID sinh vien: ");
            StudentID = Console.ReadLine();
            System.Console.Write("Ma sinh vien: ");
            MaSV = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Dia chi: ");
            Address = Console.ReadLine();
        }
        public void HienThiTT()
        {
            System.Console.WriteLine("Ten sinh vien: ", StudentName);
            System.Console.WriteLine("ID sinh vien: ", StudentID);
            System.Console.WriteLine("Ma sinh vien: ", MaSV);
            System.Console.WriteLine("Dia chi: ", Address);
        }
    }
}