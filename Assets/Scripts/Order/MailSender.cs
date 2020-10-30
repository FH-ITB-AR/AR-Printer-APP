using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class MailSender : MonoBehaviour
{
    public InputField kundeName;
    public InputField mail1;
    public InputField mail2;
    public InputField raum;
    public GameObject bestätigung1;
    public GameObject bestätigung2;
    public GameObject eingabePrüfen;
   // public Animator EingabePrüfen;


    public void eingabenSpeichern()
    {
        if (kundeName.text != "" && mail1.text != "" && mail2.text != "" && mail1.text == mail2.text)
        {
            PlayerPrefs.SetString("kundeName", kundeName.text.ToString());
            PlayerPrefs.SetString("mail1", mail1.text.ToString());
            PlayerPrefs.SetString("mail2", mail2.text.ToString());
            PlayerPrefs.SetString("raum", raum.text.ToString());
            PlayerPrefs.Save();
            bestätigung1.SetActive(true);
        }
        else
        {
            eingabePrüfen.SetActive(true);
        }
    }   
    
    public void spätereingeben()
    {
        PlayerPrefs.SetString("kundeName", "");
        PlayerPrefs.Save();
    }


    public void SendEmail()
    {
        kundeName.text = PlayerPrefs.GetString("kundeName");
        mail1.text = PlayerPrefs.GetString("mail1");
        mail2.text = PlayerPrefs.GetString("mail2");
        raum.text = PlayerPrefs.GetString("raum");
        if (kundeName.text != "" && mail1.text != "" && mail2.text != "" && mail1.text == mail2.text && raum.text != "")
        {
            MailAbsenden();
            bestätigung2.SetActive(true);
        }
    }

    private void MailAbsenden()
    {
        MailMessage mail = new MailMessage();

       /* mail.From = new MailAddress("ProvelopTest@googlemail.com");

        mail.To.Add("tim.seyock@gmx.de");

        mail.Subject = "Test Bestellvorgang";

        mail.Body = "Folgende Bestellung ist eingegangen:" + "\n" + "\n" + "Name: " + kundeName.text.ToString() + "\n" + "E-Mail Adresse: " + mail1.text.ToString() + "\n" + "Gebäude + Raum: " + raum.text.ToString() + "\n" + "\n" + "Artikel:" + "\n" + Bestellvorgang.bestelltext.ToString();

        // you can use others too.
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

        smtpServer.Port = 587;

        smtpServer.Credentials = new System.Net.NetworkCredential("ProvelopTest@googlemail.com", "provelop321") as ICredentialsByHost;

        smtpServer.EnableSsl = true;

        ServicePointManager.ServerCertificateValidationCallback =

        delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)

        { return true; };

        smtpServer.Send(mail); */
    }
}
