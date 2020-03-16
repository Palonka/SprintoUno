using System;

public abstract class Contact
{
    private int contactID;
    private string contactFname;
    private string contactLname;
    private string contactTel;
    private string contactEmail;
    private string contactAddr1;
    private string contactAddr2;
    private string contactCity;
    private string contactPostcode;

    public int getContactID { get; set; }
    private string contactFname { get; set; }
    private string contactLname { get; set; }
    private string contactTel { get; set; }
    private string contactEmail { get; set; }
    private string contactAddr1 { get; set; }
    private string contactAddr2 { get; set; }
    private string contactCity { get; set; }
    private string contactPostcode { get; set; }
}
public  class PersnalContact: Contact
{
    private string contactHomeTel;
    private string contactHomeTel { get; set; }
}
public class BusinessContact : Contact
{
    private string contactBusinessTel;
    private string contactBusinessTel { get; set; }
}
