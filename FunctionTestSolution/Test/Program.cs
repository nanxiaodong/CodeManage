using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class route {
    
    private routeSupplier supplierField;
    
    private routeSummary summaryField;
    
    private routeDays daysField;
    
    private routePackages packagesField;
    
    private routeAdditionals additionalsField;
    
    /// <remarks/>
    public routeSupplier supplier {
        get {
            return this.supplierField;
        }
        set {
            this.supplierField = value;
        }
    }
    
    /// <remarks/>
    public routeSummary summary {
        get {
            return this.summaryField;
        }
        set {
            this.summaryField = value;
        }
    }
    
    /// <remarks/>
    public routeDays days {
        get {
            return this.daysField;
        }
        set {
            this.daysField = value;
        }
    }
    
    /// <remarks/>
    public routePackages packages {
        get {
            return this.packagesField;
        }
        set {
            this.packagesField = value;
        }
    }
    
    /// <remarks/>
    public routeAdditionals additionals {
        get {
            return this.additionalsField;
        }
        set {
            this.additionalsField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeSupplier {
    
    private string nameField;
    
    private string contactuserField;
    
    private string contactphoneField;
    
    private string contactemailField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string contactuser {
        get {
            return this.contactuserField;
        }
        set {
            this.contactuserField = value;
        }
    }
    
    /// <remarks/>
    public string contactphone {
        get {
            return this.contactphoneField;
        }
        set {
            this.contactphoneField = value;
        }
    }
    
    /// <remarks/>
    public string contactemail {
        get {
            return this.contactemailField;
        }
        set {
            this.contactemailField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeSummary {
    
    private string titleField;
    
    private string teamnoField;
    
    private string resourceidField;
    
    private string pfunctionField;
    
    private string teamtypeField;
    
    private string pcompositionField;
    
    private string passengerinfoField;
    
    private string promiseField;
    
    private string dayField;
    
    private string nightField;
    
    private string advancedayField;
    
    private string advancedaytypeField;
    
    private string departureField;
    
    private string arriveField;
    
    private string arrivetypeField;
    
    private string distancetypeField;
    
    private string freetriptotrafficField;
    
    private string freetripbacktrafficField;
    
    private string imageField;
    
    private string recommendationField;
    
    private string featureField;
    
    private string visaField;
    
    private string feeincludeField;
    
    private string feeexcludeField;
    
    private string attentionField;
    
    private string tipField;
    
    private string paywayField;
    
    private string istaocanField;
    
    private string taocanadultcountField;
    
    private string taocanchildcountField;
    
    private string taocanroomcountField;
    
    private string groupmethodField;
    
    private string assemblyField;
    
    private string refundIdField;
    
    private string statusField;
    
    private string needupdatesetField;
    
    /// <remarks/>
    public string title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    public string teamno {
        get {
            return this.teamnoField;
        }
        set {
            this.teamnoField = value;
        }
    }
    
    /// <remarks/>
    public string resourceid {
        get {
            return this.resourceidField;
        }
        set {
            this.resourceidField = value;
        }
    }
    
    /// <remarks/>
    public string pfunction {
        get {
            return this.pfunctionField;
        }
        set {
            this.pfunctionField = value;
        }
    }
    
    /// <remarks/>
    public string teamtype {
        get {
            return this.teamtypeField;
        }
        set {
            this.teamtypeField = value;
        }
    }
    
    /// <remarks/>
    public string pcomposition {
        get {
            return this.pcompositionField;
        }
        set {
            this.pcompositionField = value;
        }
    }
    
    /// <remarks/>
    public string passengerinfo {
        get {
            return this.passengerinfoField;
        }
        set {
            this.passengerinfoField = value;
        }
    }
    
    /// <remarks/>
    public string promise {
        get {
            return this.promiseField;
        }
        set {
            this.promiseField = value;
        }
    }
    
    /// <remarks/>
    public string day {
        get {
            return this.dayField;
        }
        set {
            this.dayField = value;
        }
    }
    
    /// <remarks/>
    public string night {
        get {
            return this.nightField;
        }
        set {
            this.nightField = value;
        }
    }
    
    /// <remarks/>
    public string advanceday {
        get {
            return this.advancedayField;
        }
        set {
            this.advancedayField = value;
        }
    }
    
    /// <remarks/>
    public string advancedaytype {
        get {
            return this.advancedaytypeField;
        }
        set {
            this.advancedaytypeField = value;
        }
    }
    
    /// <remarks/>
    public string departure {
        get {
            return this.departureField;
        }
        set {
            this.departureField = value;
        }
    }
    
    /// <remarks/>
    public string arrive {
        get {
            return this.arriveField;
        }
        set {
            this.arriveField = value;
        }
    }
    
    /// <remarks/>
    public string arrivetype {
        get {
            return this.arrivetypeField;
        }
        set {
            this.arrivetypeField = value;
        }
    }
    
    /// <remarks/>
    public string distancetype {
        get {
            return this.distancetypeField;
        }
        set {
            this.distancetypeField = value;
        }
    }
    
    /// <remarks/>
    public string freetriptotraffic {
        get {
            return this.freetriptotrafficField;
        }
        set {
            this.freetriptotrafficField = value;
        }
    }
    
    /// <remarks/>
    public string freetripbacktraffic {
        get {
            return this.freetripbacktrafficField;
        }
        set {
            this.freetripbacktrafficField = value;
        }
    }
    
    /// <remarks/>
    public string image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    public string recommendation {
        get {
            return this.recommendationField;
        }
        set {
            this.recommendationField = value;
        }
    }
    
    /// <remarks/>
    public string feature {
        get {
            return this.featureField;
        }
        set {
            this.featureField = value;
        }
    }
    
    /// <remarks/>
    public string visa {
        get {
            return this.visaField;
        }
        set {
            this.visaField = value;
        }
    }
    
    /// <remarks/>
    public string feeinclude {
        get {
            return this.feeincludeField;
        }
        set {
            this.feeincludeField = value;
        }
    }
    
    /// <remarks/>
    public string feeexclude {
        get {
            return this.feeexcludeField;
        }
        set {
            this.feeexcludeField = value;
        }
    }
    
    /// <remarks/>
    public string attention {
        get {
            return this.attentionField;
        }
        set {
            this.attentionField = value;
        }
    }
    
    /// <remarks/>
    public string tip {
        get {
            return this.tipField;
        }
        set {
            this.tipField = value;
        }
    }
    
    /// <remarks/>
    public string payway {
        get {
            return this.paywayField;
        }
        set {
            this.paywayField = value;
        }
    }
    
    /// <remarks/>
    public string istaocan {
        get {
            return this.istaocanField;
        }
        set {
            this.istaocanField = value;
        }
    }
    
    /// <remarks/>
    public string taocanadultcount {
        get {
            return this.taocanadultcountField;
        }
        set {
            this.taocanadultcountField = value;
        }
    }
    
    /// <remarks/>
    public string taocanchildcount {
        get {
            return this.taocanchildcountField;
        }
        set {
            this.taocanchildcountField = value;
        }
    }
    
    /// <remarks/>
    public string taocanroomcount {
        get {
            return this.taocanroomcountField;
        }
        set {
            this.taocanroomcountField = value;
        }
    }
    
    /// <remarks/>
    public string groupmethod {
        get {
            return this.groupmethodField;
        }
        set {
            this.groupmethodField = value;
        }
    }
    
    /// <remarks/>
    public string assembly {
        get {
            return this.assemblyField;
        }
        set {
            this.assemblyField = value;
        }
    }
    
    /// <remarks/>
    public string refundId {
        get {
            return this.refundIdField;
        }
        set {
            this.refundIdField = value;
        }
    }
    
    /// <remarks/>
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    public string needupdateset {
        get {
            return this.needupdatesetField;
        }
        set {
            this.needupdatesetField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeDays {
    
    private routeDaysDay dayField;
    
    private string isupdateField;
    
    /// <remarks/>
    public routeDaysDay day {
        get {
            return this.dayField;
        }
        set {
            this.dayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeDaysDay {
    
    private string sightimageField;
    
    private string daydescriptionField;
    
    private string daytrafficField;
    
    private routeDaysDayDayhotelstar dayhotelstarField;
    
    private routeDaysDayMeal[] mealsField;
    
    private string daynumField;
    
    private string daytitleField;
    
    /// <remarks/>
    public string sightimage {
        get {
            return this.sightimageField;
        }
        set {
            this.sightimageField = value;
        }
    }
    
    /// <remarks/>
    public string daydescription {
        get {
            return this.daydescriptionField;
        }
        set {
            this.daydescriptionField = value;
        }
    }
    
    /// <remarks/>
    public string daytraffic {
        get {
            return this.daytrafficField;
        }
        set {
            this.daytrafficField = value;
        }
    }
    
    /// <remarks/>
    public routeDaysDayDayhotelstar dayhotelstar {
        get {
            return this.dayhotelstarField;
        }
        set {
            this.dayhotelstarField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("meal", IsNullable=false)]
    public routeDaysDayMeal[] meals {
        get {
            return this.mealsField;
        }
        set {
            this.mealsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string daynum {
        get {
            return this.daynumField;
        }
        set {
            this.daynumField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string daytitle {
        get {
            return this.daytitleField;
        }
        set {
            this.daytitleField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeDaysDayDayhotelstar {
    
    private string starnameField;
    
    private string stardescField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string starname {
        get {
            return this.starnameField;
        }
        set {
            this.starnameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stardesc {
        get {
            return this.stardescField;
        }
        set {
            this.stardescField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeDaysDayMeal {
    
    private string mealtypeField;
    
    private string mealdescField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string mealtype {
        get {
            return this.mealtypeField;
        }
        set {
            this.mealtypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string mealdesc {
        get {
            return this.mealdescField;
        }
        set {
            this.mealdescField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackages {
    
    private routePackagesPackage packageField;
    
    /// <remarks/>
    public routePackagesPackage package {
        get {
            return this.packageField;
        }
        set {
            this.packageField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackage {
    
    private routePackagesPackageTraffics trafficsField;
    
    private routePackagesPackageHotels hotelsField;
    
    private routePackagesPackageAdditionals additionalsField;
    
    private routePackagesPackageTickets ticketsField;
    
    private routePackagesPackageFreetripvisainfo freetripvisainfoField;
    
    private routePackagesPackageFreetrippickupairinfo freetrippickupairinfoField;
    
    private routePackagesPackageFreetripotherinfo freetripotherinfoField;
    
    private string idField;
    
    private string statusField;
    
    /// <remarks/>
    public routePackagesPackageTraffics traffics {
        get {
            return this.trafficsField;
        }
        set {
            this.trafficsField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageHotels hotels {
        get {
            return this.hotelsField;
        }
        set {
            this.hotelsField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageAdditionals additionals {
        get {
            return this.additionalsField;
        }
        set {
            this.additionalsField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageTickets tickets {
        get {
            return this.ticketsField;
        }
        set {
            this.ticketsField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageFreetripvisainfo freetripvisainfo {
        get {
            return this.freetripvisainfoField;
        }
        set {
            this.freetripvisainfoField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageFreetrippickupairinfo freetrippickupairinfo {
        get {
            return this.freetrippickupairinfoField;
        }
        set {
            this.freetrippickupairinfoField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageFreetripotherinfo freetripotherinfo {
        get {
            return this.freetripotherinfoField;
        }
        set {
            this.freetripotherinfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTraffics {
    
    private routePackagesPackageTrafficsTraffic trafficField;
    
    private string isupdateField;
    
    /// <remarks/>
    public routePackagesPackageTrafficsTraffic traffic {
        get {
            return this.trafficField;
        }
        set {
            this.trafficField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTraffic {
    
    private routePackagesPackageTrafficsTrafficTotraffic totrafficField;
    
    private routePackagesPackageTrafficsTrafficBacktraffic backtrafficField;
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficTotraffic totraffic {
        get {
            return this.totrafficField;
        }
        set {
            this.totrafficField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficBacktraffic backtraffic {
        get {
            return this.backtrafficField;
        }
        set {
            this.backtrafficField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficTotraffic {
    
    private routePackagesPackageTrafficsTrafficTotrafficFlight flightField;
    
    private routePackagesPackageTrafficsTrafficTotrafficTrain trainField;
    
    private routePackagesPackageTrafficsTrafficTotrafficBus busField;
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficTotrafficFlight flight {
        get {
            return this.flightField;
        }
        set {
            this.flightField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficTotrafficTrain train {
        get {
            return this.trainField;
        }
        set {
            this.trainField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficTotrafficBus bus {
        get {
            return this.busField;
        }
        set {
            this.busField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficTotrafficFlight {
    
    private string seqField;
    
    private string flightnoField;
    
    private string plantypeField;
    
    private string depairportField;
    
    private string arrairportField;
    
    private string depcityField;
    
    private string arrcityField;
    
    private string deptimeField;
    
    private string arrtimeField;
    
    private string arrflagField;
    
    private string stopflagField;
    
    private string stopcommentField;
    
    private string transeferField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string flightno {
        get {
            return this.flightnoField;
        }
        set {
            this.flightnoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string plantype {
        get {
            return this.plantypeField;
        }
        set {
            this.plantypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string depairport {
        get {
            return this.depairportField;
        }
        set {
            this.depairportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrairport {
        get {
            return this.arrairportField;
        }
        set {
            this.arrairportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string depcity {
        get {
            return this.depcityField;
        }
        set {
            this.depcityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrcity {
        get {
            return this.arrcityField;
        }
        set {
            this.arrcityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string deptime {
        get {
            return this.deptimeField;
        }
        set {
            this.deptimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrtime {
        get {
            return this.arrtimeField;
        }
        set {
            this.arrtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrflag {
        get {
            return this.arrflagField;
        }
        set {
            this.arrflagField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stopflag {
        get {
            return this.stopflagField;
        }
        set {
            this.stopflagField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stopcomment {
        get {
            return this.stopcommentField;
        }
        set {
            this.stopcommentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transefer {
        get {
            return this.transeferField;
        }
        set {
            this.transeferField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficTotrafficTrain {
    
    private string seqField;
    
    private string trainnoField;
    
    private string trainmodelField;
    
    private string depstationField;
    
    private string arrstationField;
    
    private string deptimeField;
    
    private string arrtimeField;
    
    private string traintimeField;
    
    private string trainseatField;
    
    private string transeferField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainno {
        get {
            return this.trainnoField;
        }
        set {
            this.trainnoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainmodel {
        get {
            return this.trainmodelField;
        }
        set {
            this.trainmodelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string depstation {
        get {
            return this.depstationField;
        }
        set {
            this.depstationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrstation {
        get {
            return this.arrstationField;
        }
        set {
            this.arrstationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string deptime {
        get {
            return this.deptimeField;
        }
        set {
            this.deptimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrtime {
        get {
            return this.arrtimeField;
        }
        set {
            this.arrtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string traintime {
        get {
            return this.traintimeField;
        }
        set {
            this.traintimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainseat {
        get {
            return this.trainseatField;
        }
        set {
            this.trainseatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transefer {
        get {
            return this.transeferField;
        }
        set {
            this.transeferField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficTotrafficBus {
    
    private string seqField;
    
    private string busmodelField;
    
    private string seatcountField;
    
    private string gathertimeField;
    
    private string gatherspotField;
    
    private string deptimeField;
    
    private string arrtimeField;
    
    private string remarksField;
    
    private string transeferField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string busmodel {
        get {
            return this.busmodelField;
        }
        set {
            this.busmodelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seatcount {
        get {
            return this.seatcountField;
        }
        set {
            this.seatcountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string gathertime {
        get {
            return this.gathertimeField;
        }
        set {
            this.gathertimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string gatherspot {
        get {
            return this.gatherspotField;
        }
        set {
            this.gatherspotField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string deptime {
        get {
            return this.deptimeField;
        }
        set {
            this.deptimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrtime {
        get {
            return this.arrtimeField;
        }
        set {
            this.arrtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string remarks {
        get {
            return this.remarksField;
        }
        set {
            this.remarksField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transefer {
        get {
            return this.transeferField;
        }
        set {
            this.transeferField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficBacktraffic {
    
    private routePackagesPackageTrafficsTrafficBacktrafficFlight flightField;
    
    private routePackagesPackageTrafficsTrafficBacktrafficTrain trainField;
    
    private routePackagesPackageTrafficsTrafficBacktrafficBus busField;
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficBacktrafficFlight flight {
        get {
            return this.flightField;
        }
        set {
            this.flightField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficBacktrafficTrain train {
        get {
            return this.trainField;
        }
        set {
            this.trainField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageTrafficsTrafficBacktrafficBus bus {
        get {
            return this.busField;
        }
        set {
            this.busField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficBacktrafficFlight {
    
    private string seqField;
    
    private string flightnoField;
    
    private string plantypeField;
    
    private string depairportField;
    
    private string arrairportField;
    
    private string depcityField;
    
    private string arrcityField;
    
    private string deptimeField;
    
    private string arrtimeField;
    
    private string arrflagField;
    
    private string stopflagField;
    
    private string stopcommentField;
    
    private string transeferField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string flightno {
        get {
            return this.flightnoField;
        }
        set {
            this.flightnoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string plantype {
        get {
            return this.plantypeField;
        }
        set {
            this.plantypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string depairport {
        get {
            return this.depairportField;
        }
        set {
            this.depairportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrairport {
        get {
            return this.arrairportField;
        }
        set {
            this.arrairportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string depcity {
        get {
            return this.depcityField;
        }
        set {
            this.depcityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrcity {
        get {
            return this.arrcityField;
        }
        set {
            this.arrcityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string deptime {
        get {
            return this.deptimeField;
        }
        set {
            this.deptimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrtime {
        get {
            return this.arrtimeField;
        }
        set {
            this.arrtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrflag {
        get {
            return this.arrflagField;
        }
        set {
            this.arrflagField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stopflag {
        get {
            return this.stopflagField;
        }
        set {
            this.stopflagField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stopcomment {
        get {
            return this.stopcommentField;
        }
        set {
            this.stopcommentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transefer {
        get {
            return this.transeferField;
        }
        set {
            this.transeferField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficBacktrafficTrain {
    
    private string seqField;
    
    private string trainnoField;
    
    private string trainmodelField;
    
    private string depstationField;
    
    private string arrstationField;
    
    private string deptimeField;
    
    private string arrtimeField;
    
    private string traintimeField;
    
    private string trainseatField;
    
    private string transeferField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainno {
        get {
            return this.trainnoField;
        }
        set {
            this.trainnoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainmodel {
        get {
            return this.trainmodelField;
        }
        set {
            this.trainmodelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string depstation {
        get {
            return this.depstationField;
        }
        set {
            this.depstationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrstation {
        get {
            return this.arrstationField;
        }
        set {
            this.arrstationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string deptime {
        get {
            return this.deptimeField;
        }
        set {
            this.deptimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrtime {
        get {
            return this.arrtimeField;
        }
        set {
            this.arrtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string traintime {
        get {
            return this.traintimeField;
        }
        set {
            this.traintimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string trainseat {
        get {
            return this.trainseatField;
        }
        set {
            this.trainseatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transefer {
        get {
            return this.transeferField;
        }
        set {
            this.transeferField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTrafficsTrafficBacktrafficBus {
    
    private string seqField;
    
    private string busmodelField;
    
    private string seatcountField;
    
    private string gathertimeField;
    
    private string gatherspotField;
    
    private string deptimeField;
    
    private string arrtimeField;
    
    private string remarksField;
    
    private string transeferField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string busmodel {
        get {
            return this.busmodelField;
        }
        set {
            this.busmodelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string seatcount {
        get {
            return this.seatcountField;
        }
        set {
            this.seatcountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string gathertime {
        get {
            return this.gathertimeField;
        }
        set {
            this.gathertimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string gatherspot {
        get {
            return this.gatherspotField;
        }
        set {
            this.gatherspotField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string deptime {
        get {
            return this.deptimeField;
        }
        set {
            this.deptimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string arrtime {
        get {
            return this.arrtimeField;
        }
        set {
            this.arrtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string remarks {
        get {
            return this.remarksField;
        }
        set {
            this.remarksField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transefer {
        get {
            return this.transeferField;
        }
        set {
            this.transeferField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageHotels {
    
    private routePackagesPackageHotelsHotelprogram hotelprogramField;
    
    private string isupdateField;
    
    /// <remarks/>
    public routePackagesPackageHotelsHotelprogram hotelprogram {
        get {
            return this.hotelprogramField;
        }
        set {
            this.hotelprogramField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageHotelsHotelprogram {
    
    private routePackagesPackageHotelsHotelprogramHotel hotelField;
    
    /// <remarks/>
    public routePackagesPackageHotelsHotelprogramHotel hotel {
        get {
            return this.hotelField;
        }
        set {
            this.hotelField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageHotelsHotelprogramHotel {
    
    private string seqField;
    
    private string startnightField;
    
    private string endnightField;
    
    private string hotelcityField;
    
    private string hotelnameField;
    
    private string hotelmarkField;
    
    private string hotelenglistnameField;
    
    private string bookdayField;
    
    private routePackagesPackageHotelsHotelprogramHotelHotelstar hotelstarField;
    
    private string hotelgradeField;
    
    private string bedtypeField;
    
    private string roomtypeField;
    
    private string roomnameField;
    
    private string roomenglishField;
    
    private string addressField;
    
    private string websiteField;
    
    private string imageField;
    
    private string introductionField;
    
    private routePackagesPackageHotelsHotelprogramHotelMeal mealField;
    
    private string networkField;
    
    private string relateidField;
    
    /// <remarks/>
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    public string startnight {
        get {
            return this.startnightField;
        }
        set {
            this.startnightField = value;
        }
    }
    
    /// <remarks/>
    public string endnight {
        get {
            return this.endnightField;
        }
        set {
            this.endnightField = value;
        }
    }
    
    /// <remarks/>
    public string hotelcity {
        get {
            return this.hotelcityField;
        }
        set {
            this.hotelcityField = value;
        }
    }
    
    /// <remarks/>
    public string hotelname {
        get {
            return this.hotelnameField;
        }
        set {
            this.hotelnameField = value;
        }
    }
    
    /// <remarks/>
    public string hotelmark {
        get {
            return this.hotelmarkField;
        }
        set {
            this.hotelmarkField = value;
        }
    }
    
    /// <remarks/>
    public string hotelenglistname {
        get {
            return this.hotelenglistnameField;
        }
        set {
            this.hotelenglistnameField = value;
        }
    }
    
    /// <remarks/>
    public string bookday {
        get {
            return this.bookdayField;
        }
        set {
            this.bookdayField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageHotelsHotelprogramHotelHotelstar hotelstar {
        get {
            return this.hotelstarField;
        }
        set {
            this.hotelstarField = value;
        }
    }
    
    /// <remarks/>
    public string hotelgrade {
        get {
            return this.hotelgradeField;
        }
        set {
            this.hotelgradeField = value;
        }
    }
    
    /// <remarks/>
    public string bedtype {
        get {
            return this.bedtypeField;
        }
        set {
            this.bedtypeField = value;
        }
    }
    
    /// <remarks/>
    public string roomtype {
        get {
            return this.roomtypeField;
        }
        set {
            this.roomtypeField = value;
        }
    }
    
    /// <remarks/>
    public string roomname {
        get {
            return this.roomnameField;
        }
        set {
            this.roomnameField = value;
        }
    }
    
    /// <remarks/>
    public string roomenglish {
        get {
            return this.roomenglishField;
        }
        set {
            this.roomenglishField = value;
        }
    }
    
    /// <remarks/>
    public string address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string website {
        get {
            return this.websiteField;
        }
        set {
            this.websiteField = value;
        }
    }
    
    /// <remarks/>
    public string image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    public string introduction {
        get {
            return this.introductionField;
        }
        set {
            this.introductionField = value;
        }
    }
    
    /// <remarks/>
    public routePackagesPackageHotelsHotelprogramHotelMeal meal {
        get {
            return this.mealField;
        }
        set {
            this.mealField = value;
        }
    }
    
    /// <remarks/>
    public string network {
        get {
            return this.networkField;
        }
        set {
            this.networkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string relateid {
        get {
            return this.relateidField;
        }
        set {
            this.relateidField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageHotelsHotelprogramHotelHotelstar {
    
    private string starnameField;
    
    private string stardescField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string starname {
        get {
            return this.starnameField;
        }
        set {
            this.starnameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string stardesc {
        get {
            return this.stardescField;
        }
        set {
            this.stardescField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageHotelsHotelprogramHotelMeal {
    
    private string breakfastField;
    
    private string lunchField;
    
    private string dinnerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string breakfast {
        get {
            return this.breakfastField;
        }
        set {
            this.breakfastField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string lunch {
        get {
            return this.lunchField;
        }
        set {
            this.lunchField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string dinner {
        get {
            return this.dinnerField;
        }
        set {
            this.dinnerField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageAdditionals {
    
    private routePackagesPackageAdditionalsAdditional additionalField;
    
    private string isupdateField;
    
    /// <remarks/>
    public routePackagesPackageAdditionalsAdditional additional {
        get {
            return this.additionalField;
        }
        set {
            this.additionalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageAdditionalsAdditional {
    
    private string typeField;
    
    private string additiontitleField;
    
    private string additiondescField;
    
    private string additionusedescField;
    
    /// <remarks/>
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    public string additiontitle {
        get {
            return this.additiontitleField;
        }
        set {
            this.additiontitleField = value;
        }
    }
    
    /// <remarks/>
    public string additiondesc {
        get {
            return this.additiondescField;
        }
        set {
            this.additiondescField = value;
        }
    }
    
    /// <remarks/>
    public string additionusedesc {
        get {
            return this.additionusedescField;
        }
        set {
            this.additionusedescField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTickets {
    
    private routePackagesPackageTicketsTicket ticketField;
    
    private string isupdateField;
    
    /// <remarks/>
    public routePackagesPackageTicketsTicket ticket {
        get {
            return this.ticketField;
        }
        set {
            this.ticketField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageTicketsTicket {
    
    private string seqField;
    
    private string tickettitleField;
    
    private string sightnameField;
    
    private string starField;
    
    private string addressField;
    
    private string opentimeField;
    
    private string imageField;
    
    private string introductionField;
    
    private string relateidField;
    
    /// <remarks/>
    public string seq {
        get {
            return this.seqField;
        }
        set {
            this.seqField = value;
        }
    }
    
    /// <remarks/>
    public string tickettitle {
        get {
            return this.tickettitleField;
        }
        set {
            this.tickettitleField = value;
        }
    }
    
    /// <remarks/>
    public string sightname {
        get {
            return this.sightnameField;
        }
        set {
            this.sightnameField = value;
        }
    }
    
    /// <remarks/>
    public string star {
        get {
            return this.starField;
        }
        set {
            this.starField = value;
        }
    }
    
    /// <remarks/>
    public string address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string opentime {
        get {
            return this.opentimeField;
        }
        set {
            this.opentimeField = value;
        }
    }
    
    /// <remarks/>
    public string image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    public string introduction {
        get {
            return this.introductionField;
        }
        set {
            this.introductionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string relateid {
        get {
            return this.relateidField;
        }
        set {
            this.relateidField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageFreetripvisainfo {
    
    private string isupdateField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageFreetrippickupairinfo {
    
    private string isupdateField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routePackagesPackageFreetripotherinfo {
    
    private string isupdateField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeAdditionals {
    
    private routeAdditionalsAdditional additionalField;
    
    private string isupdateField;
    
    /// <remarks/>
    public routeAdditionalsAdditional additional {
        get {
            return this.additionalField;
        }
        set {
            this.additionalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string isupdate {
        get {
            return this.isupdateField;
        }
        set {
            this.isupdateField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class routeAdditionalsAdditional {
    
    private string typeField;
    
    private string additiontitleField;
    
    private string additiondescField;
    
    private string additionusedescField;
    
    private string statusField;
    
    private string idField;
    
    /// <remarks/>
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    public string additiontitle {
        get {
            return this.additiontitleField;
        }
        set {
            this.additiontitleField = value;
        }
    }
    
    /// <remarks/>
    public string additiondesc {
        get {
            return this.additiondescField;
        }
        set {
            this.additiondescField = value;
        }
    }
    
    /// <remarks/>
    public string additionusedesc {
        get {
            return this.additionusedescField;
        }
        set {
            this.additionusedescField = value;
        }
    }
    
    /// <remarks/>
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}


        }
    }
}
