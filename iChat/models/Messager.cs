using System;
using System.ComponentModel.DataAnnotations;

public class Messager
{
    [Key]
    public int Id { get; set; }

    public int SenderId { get; set; }        // ✅ Quem enviou
    public int ReceiverId { get; set; }      // ✅ Quem recebe

    public string MessageEncrypted { get; set; }  // ✅ Mensagem cifrada com AES
    public string Signature { get; set; }         // ✅ Assinatura RSA do remetente
    public DateTime Timestamp { get; set; }       // ✅ Quando foi enviada
}
