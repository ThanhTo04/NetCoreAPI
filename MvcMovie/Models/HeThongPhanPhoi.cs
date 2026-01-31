public class HeThongPhanPhoi
{
    public string MaHTPP { get; set; }
    public string TenHTPP { get; set; }

    public HeThongPhanPhoi() { }

    public HeThongPhanPhoi(string maHTPP, string tenHTPP)
    {
        MaHTPP = maHTPP;
        TenHTPP = tenHTPP;
    }
}
