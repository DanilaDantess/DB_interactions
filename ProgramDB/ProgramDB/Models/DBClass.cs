namespace ProgramDB.Models
{
    public class DBClass
    {
        public int Id { get; set; }
        public TimeSpan time { get; set; }
        public Int16 Ms { get; set; }
        public Byte Kontroller { get; set; }
        public Decimal Sila_tyagi { get; set; }
        public Decimal Napryajenie { get; set; }
        public Decimal Tok_generatora { get; set; }
        public Decimal Tor_kompressora { get; set; }
        public Int16 Temp_gazov_B1 { get; set; }
        public Int16 Temp_gazov_A5 { get; set; }
        public Decimal Tok_ADT { get; set; }
        public Int16 Vyhod_TNVD { get; set; }
        public Int16 Chastota_vrascheniya { get; set; }

    }
}