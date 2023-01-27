namespace ArquivoCsvBlazorApp.Models
{
    public class CsvFile
    {
        public CsvFile(
            long ccnpjCpf,
            long cflialCnpj,
            long cctrlCnpjCpf,
            long cpfOriginal,
            int ctpoPssoa,
            string rest,
            string grau)
        {
            CCNPJ_CPF = ccnpjCpf;
            CFLIAL_CNPJ = cflialCnpj;
            CCTRL_CNPJ_CPF = cctrlCnpjCpf;
            CPF_ORIGINAL = cpfOriginal;
            CTPO_PSSOA = ctpoPssoa;
            REST = rest;
            GRAU = grau;
        }

        public long CCNPJ_CPF { get; set; }
        public long CFLIAL_CNPJ { get; set; }
        public long CCTRL_CNPJ_CPF { get; set; }
        public long CPF_ORIGINAL { get; set; }
        public int CTPO_PSSOA { get; set; }
        public string REST { get; set; }
        public string GRAU { get; set; }

    }


}