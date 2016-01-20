
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class adultprice
{

    private string floorpriceField;

    private string distributpercentField;

    private string suggestpercentField;

    private string distributpriceField;

    private string suggestpriceField;

    private string typeField;

    /// <remarks/>
    public string floorprice
    {
        get
        {
            return this.floorpriceField;
        }
        set
        {
            this.floorpriceField = value;
        }
    }

    /// <remarks/>
    public string distributpercent
    {
        get
        {
            return this.distributpercentField;
        }
        set
        {
            this.distributpercentField = value;
        }
    }

    /// <remarks/>
    public string suggestpercent
    {
        get
        {
            return this.suggestpercentField;
        }
        set
        {
            this.suggestpercentField = value;
        }
    }

    /// <remarks/>
    public string distributprice
    {
        get
        {
            return this.distributpriceField;
        }
        set
        {
            this.distributpriceField = value;
        }
    }

    /// <remarks/>
    public string suggestprice
    {
        get
        {
            return this.suggestpriceField;
        }
        set
        {
            this.suggestpriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

