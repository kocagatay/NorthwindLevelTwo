using System.ComponentModel.DataAnnotations;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage = "İsim gerekli")] //Data Annotation SOLİD'in S Harfine uyan bir uygulama değildir. Tc kimlik örneği yabancı uyruklular için.
        //FLUENTVALİDATİON'DA YAZDIK AMA BEN BİLDİĞİM İÇİN YAZMADIM ONU BACKEND'DE HALLEDİYORUZ BUSİNESS'DA HER ZAMANKİ GİBİ
        //ONA EK OLARAK 2 RULE FOR'UN BİRBİRİNE BAĞLANTILI KURALLANMASINI GÖSTERDİ
        //ÖRNEK: RuleFor(s=>s.City).NotEmpty().When(s=>s.Age<18); 18 YAŞINDAN KÜÇÜKSE ŞEHİR BİLGİSİNİ O ZAMAN GİRMESİ ZORUNLU GİBİ.
        public string? FirstName { get; set; }
        // [Required]
        public string? LastName { get; set; }
        //[Required]
        // [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        //[Required]
        public string? City { get; set; }
        //[Required]
        public string? Address { get; set; }
        // [Required]
        // [Range(18, 65)]
        public int Age { get; set; }
    }
}
