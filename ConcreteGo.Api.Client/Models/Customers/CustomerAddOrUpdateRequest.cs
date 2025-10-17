using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Customers
{
    [XmlRoot(ElementName = "CustomerUpdateRq", Namespace = "")]
    public class CustomerAddOrUpdateRequest
    {
        [XmlElement(ElementName = "CustomerUpdate")]
        public List<CustomerUpdate>? CustomerUpdate { get; set; }
    }

    [XmlRoot(ElementName = "CustomerUpdate")]
    public class CustomerUpdate
    {
        /// <summary>
        /// Customer ID
        /// </summary>
        [XmlElement("ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() => ID.HasValue;

        /// <summary>
        /// Customer code
        /// </summary>
        [XmlElement("Code")]
        public string? Code { get; set; }
        public bool ShouldSerializeCode() => !string.IsNullOrEmpty(Code);

        /// <summary>
        /// Customer name
        /// </summary>
        [XmlElement("Name")]
        public string? Name { get; set; }
        public bool ShouldSerializeName() => !string.IsNullOrEmpty(Name);

        /// <summary>
        /// Action to perform (Add, Update, etc.)
        /// </summary>
        [XmlElement("Action")]
        public string? Action { get; set; }
        public bool ShouldSerializeAction() => !string.IsNullOrEmpty(Action);

        /// <summary>
        /// Setup date
        /// </summary>
        [XmlElement("SetupDate")]
        public DateTime? SetupDate { get; set; }
        public bool ShouldSerializeSetupDate() => SetupDate.HasValue;

        /// <summary>
        /// Sort name
        /// </summary>
        [XmlElement("SortName")]
        public string? SortName { get; set; }
        public bool ShouldSerializeSortName() => !string.IsNullOrEmpty(SortName);

        /// <summary>
        /// Customer address
        /// </summary>
        [XmlElement("Address")]
        public CustomerAddress? Address { get; set; }
        public bool ShouldSerializeAddress() => Address != null;

        /// <summary>
        /// Invoice address
        /// </summary>
        [XmlElement("InvoiceAddress")]
        public CustomerInvoiceAddress? InvoiceAddress { get; set; }
        public bool ShouldSerializeInvoiceAddress() => InvoiceAddress != null;

        /// <summary>
        /// Statement address
        /// </summary>
        [XmlElement("StatementAddress")]
        public CustomerStatementAddress? StatementAddress { get; set; }
        public bool ShouldSerializeStatementAddress() => StatementAddress != null;

        /// <summary>
        /// Contact name
        /// </summary>
        [XmlElement("Contact")]
        public string? Contact { get; set; }
        public bool ShouldSerializeContact() => !string.IsNullOrEmpty(Contact);

        /// <summary>
        /// Phone number
        /// </summary>
        [XmlElement("Phone")]
        public string? Phone { get; set; }
        public bool ShouldSerializePhone() => !string.IsNullOrEmpty(Phone);

        /// <summary>
        /// Fax number
        /// </summary>
        [XmlElement("Fax")]
        public string? Fax { get; set; }
        public bool ShouldSerializeFax() => !string.IsNullOrEmpty(Fax);

        /// <summary>
        /// Cellular number
        /// </summary>
        [XmlElement("Cellular")]
        public string? Cellular { get; set; }
        public bool ShouldSerializeCellular() => !string.IsNullOrEmpty(Cellular);

        /// <summary>
        /// Email address
        /// </summary>
        [XmlElement("Email")]
        public string? Email { get; set; }
        public bool ShouldSerializeEmail() => !string.IsNullOrEmpty(Email);

        /// <summary>
        /// QB invoice email checked
        /// </summary>
        [XmlElement("QBInvoiceEmailChecked")]
        public bool? QBInvoiceEmailChecked { get; set; }
        public bool ShouldSerializeQBInvoiceEmailChecked() => QBInvoiceEmailChecked.HasValue;

        /// <summary>
        /// Sales information
        /// </summary>
        [XmlElement("Sales")]
        public CustomerSales? Sales { get; set; }
        public bool ShouldSerializeSales() => Sales != null;

        /// <summary>
        /// Taxing information
        /// </summary>
        [XmlElement("Taxing")]
        public CustomerTaxing? Taxing { get; set; }
        public bool ShouldSerializeTaxing() => Taxing != null;

        /// <summary>
        /// Pricing information
        /// </summary>
        [XmlElement("Pricing")]
        public CustomerPricing? Pricing { get; set; }
        public bool ShouldSerializePricing() => Pricing != null;

        /// <summary>
        /// Charges information
        /// </summary>
        [XmlElement("Charges")]
        public CustomerCharges? Charges { get; set; }
        public bool ShouldSerializeCharges() => Charges != null;

        /// <summary>
        /// Accounting information
        /// </summary>
        [XmlElement("Accounting")]
        public CustomerAccounting? Accounting { get; set; }
        public bool ShouldSerializeAccounting() => Accounting != null;

        /// <summary>
        /// Distribution information
        /// </summary>
        [XmlElement("Distribution")]
        public CustomerDistribution? Distribution { get; set; }
        public bool ShouldSerializeDistribution() => Distribution != null;

        /// <summary>
        /// Division ID
        /// </summary>
        [XmlElement("DivisionID")]
        public int? DivisionID { get; set; }
        public bool ShouldSerializeDivisionID() => DivisionID.HasValue;

        /// <summary>
        /// Division code
        /// </summary>
        [XmlElement("DivisionCode")]
        public string? DivisionCode { get; set; }
        public bool ShouldSerializeDivisionCode() => !string.IsNullOrEmpty(DivisionCode);

        /// <summary>
        /// Inactive status
        /// </summary>
        [XmlElement("InActive")]
        public bool? InActive { get; set; }
        public bool ShouldSerializeInActive() => InActive.HasValue;

        /// <summary>
        /// User defined fields
        /// </summary>
        [XmlElement("UserDefinedFields")]
        public UserDefinedFields? UserDefinedFields { get; set; }
        public bool ShouldSerializeUserDefinedFields() => UserDefinedFields != null;

        /// <summary>
        /// Elements to include in the return
        /// </summary>
        [XmlElement("IncludeRetElement")]
        public List<string>? IncludeRetElement { get; set; }
        public bool ShouldSerializeIncludeRetElement() => IncludeRetElement != null && IncludeRetElement.Count > 0;
    }

    [XmlRoot(ElementName = "Address")]
    public class CustomerAddress
    {
        [XmlElement("Addr1")]
        public string? Addr1 { get; set; }
        public bool ShouldSerializeAddr1() => !string.IsNullOrEmpty(Addr1);

        [XmlElement("Addr2")]
        public string? Addr2 { get; set; }
        public bool ShouldSerializeAddr2() => !string.IsNullOrEmpty(Addr2);

        [XmlElement("Addr3")]
        public string? Addr3 { get; set; }
        public bool ShouldSerializeAddr3() => !string.IsNullOrEmpty(Addr3);

        [XmlElement("City")]
        public string? City { get; set; }
        public bool ShouldSerializeCity() => !string.IsNullOrEmpty(City);

        [XmlElement("State")]
        public string? State { get; set; }
        public bool ShouldSerializeState() => !string.IsNullOrEmpty(State);

        [XmlElement("PostalCode")]
        public string? PostalCode { get; set; }
        public bool ShouldSerializePostalCode() => !string.IsNullOrEmpty(PostalCode);

        [XmlElement("Country")]
        public string? Country { get; set; }
        public bool ShouldSerializeCountry() => !string.IsNullOrEmpty(Country);
    }

    [XmlRoot(ElementName = "InvoiceAddress")]
    public class CustomerInvoiceAddress
    {
        [XmlElement("Name")]
        public string? Name { get; set; }
        public bool ShouldSerializeName() => !string.IsNullOrEmpty(Name);

        [XmlElement("Addr1")]
        public string? Addr1 { get; set; }
        public bool ShouldSerializeAddr1() => !string.IsNullOrEmpty(Addr1);

        [XmlElement("Addr2")]
        public string? Addr2 { get; set; }
        public bool ShouldSerializeAddr2() => !string.IsNullOrEmpty(Addr2);

        [XmlElement("City")]
        public string? City { get; set; }
        public bool ShouldSerializeCity() => !string.IsNullOrEmpty(City);

        [XmlElement("State")]
        public string? State { get; set; }
        public bool ShouldSerializeState() => !string.IsNullOrEmpty(State);

        [XmlElement("PostalCode")]
        public string? PostalCode { get; set; }
        public bool ShouldSerializePostalCode() => !string.IsNullOrEmpty(PostalCode);

        [XmlElement("Country")]
        public string? Country { get; set; }
        public bool ShouldSerializeCountry() => !string.IsNullOrEmpty(Country);
    }

    [XmlRoot(ElementName = "StatementAddress")]
    public class CustomerStatementAddress
    {
        [XmlElement("Name")]
        public string? Name { get; set; }
        public bool ShouldSerializeName() => !string.IsNullOrEmpty(Name);

        [XmlElement("Addr1")]
        public string? Addr1 { get; set; }
        public bool ShouldSerializeAddr1() => !string.IsNullOrEmpty(Addr1);

        [XmlElement("Addr2")]
        public string? Addr2 { get; set; }
        public bool ShouldSerializeAddr2() => !string.IsNullOrEmpty(Addr2);

        [XmlElement("City")]
        public string? City { get; set; }
        public bool ShouldSerializeCity() => !string.IsNullOrEmpty(City);

        [XmlElement("State")]
        public string? State { get; set; }
        public bool ShouldSerializeState() => !string.IsNullOrEmpty(State);

        [XmlElement("PostalCode")]
        public string? PostalCode { get; set; }
        public bool ShouldSerializePostalCode() => !string.IsNullOrEmpty(PostalCode);

        [XmlElement("Country")]
        public string? Country { get; set; }
        public bool ShouldSerializeCountry() => !string.IsNullOrEmpty(Country);
    }

    [XmlRoot(ElementName = "Sales")]
    public class CustomerSales
    {
        [XmlElement("SalesAnalysisCode")]
        public string? SalesAnalysisCode { get; set; }
        public bool ShouldSerializeSalesAnalysisCode() => !string.IsNullOrEmpty(SalesAnalysisCode);

        [XmlElement("SalesmanCode")]
        public string? SalesmanCode { get; set; }
        public bool ShouldSerializeSalesmanCode() => !string.IsNullOrEmpty(SalesmanCode);

        [XmlElement("SalesmanName")]
        public string? SalesmanName { get; set; }
        public bool ShouldSerializeSalesmanName() => !string.IsNullOrEmpty(SalesmanName);
    }

    [XmlRoot(ElementName = "Taxing")]
    public class CustomerTaxing
    {
        [XmlElement("TaxID")]
        public string? TaxID { get; set; }
        public bool ShouldSerializeTaxID() => !string.IsNullOrEmpty(TaxID);

        [XmlElement("TaxCode")]
        public string? TaxCode { get; set; }
        public bool ShouldSerializeTaxCode() => !string.IsNullOrEmpty(TaxCode);

        [XmlElement("Taxable")]
        public bool? Taxable { get; set; }
        public bool ShouldSerializeTaxable() => Taxable.HasValue;

        [XmlElement("NonTaxableReasonCode")]
        public string? NonTaxableReasonCode { get; set; }
        public bool ShouldSerializeNonTaxableReasonCode() => !string.IsNullOrEmpty(NonTaxableReasonCode);

        [XmlElement("TaxExcempt")]
        public CustomerTaxExempt? TaxExcempt { get; set; }
        public bool ShouldSerializeTaxExcempt() => TaxExcempt != null;
    }

    [XmlRoot(ElementName = "TaxExcempt")]
    public class CustomerTaxExempt
    {
        [XmlElement("TaxAuthorityCode")]
        public string? TaxAuthorityCode { get; set; }
        public bool ShouldSerializeTaxAuthorityCode() => !string.IsNullOrEmpty(TaxAuthorityCode);

        [XmlElement("TaxExemptID")]
        public string? TaxExemptID { get; set; }
        public bool ShouldSerializeTaxExemptID() => !string.IsNullOrEmpty(TaxExemptID);
    }

    [XmlRoot(ElementName = "Pricing")]
    public class CustomerPricing
    {
        [XmlElement("PriceCategoryCode")]
        public string? PriceCategoryCode { get; set; }
        public bool ShouldSerializePriceCategoryCode() => !string.IsNullOrEmpty(PriceCategoryCode);

        [XmlElement("PricingPlantCode")]
        public string? PricingPlantCode { get; set; }
        public bool ShouldSerializePricingPlantCode() => !string.IsNullOrEmpty(PricingPlantCode);

        [XmlElement("TradeDiscountPercent")]
        public decimal? TradeDiscountPercent { get; set; }
        public bool ShouldSerializeTradeDiscountPercent() => TradeDiscountPercent.HasValue;

        [XmlElement("TradeDiscountAmount")]
        public decimal? TradeDiscountAmount { get; set; }
        public bool ShouldSerializeTradeDiscountAmount() => TradeDiscountAmount.HasValue;

        [XmlElement("TradeDiscountAmountUnitCode")]
        public string? TradeDiscountAmountUnitCode { get; set; }
        public bool ShouldSerializeTradeDiscountAmountUnitCode() => !string.IsNullOrEmpty(TradeDiscountAmountUnitCode);

        [XmlElement("TermCode")]
        public string? TermCode { get; set; }
        public bool ShouldSerializeTermCode() => !string.IsNullOrEmpty(TermCode);

        [XmlElement("ZoneCode")]
        public string? ZoneCode { get; set; }
        public bool ShouldSerializeZoneCode() => !string.IsNullOrEmpty(ZoneCode);

        [XmlElement("OverrideChargeRate")]
        public decimal? OverrideChargeRate { get; set; }
        public bool ShouldSerializeOverrideChargeRate() => OverrideChargeRate.HasValue;

        [XmlElement("OverrideChargeEfftiveDate")]
        public DateTime? OverrideChargeEfftiveDate { get; set; }
        public bool ShouldSerializeOverrideChargeEfftiveDate() => OverrideChargeEfftiveDate.HasValue;

        [XmlElement("PreviousRate")]
        public DateTime? PreviousRate { get; set; }
        public bool ShouldSerializePreviousRate() => PreviousRate.HasValue;

        [XmlElement("ApplyZoneCharges")]
        public bool? ApplyZoneCharges { get; set; }
        public bool ShouldSerializeApplyZoneCharges() => ApplyZoneCharges.HasValue;

        [XmlElement("AllowPriceChangeInOrderEntry")]
        public bool? AllowPriceChangeInOrderEntry { get; set; }
        public bool ShouldSerializeAllowPriceChangeInOrderEntry() => AllowPriceChangeInOrderEntry.HasValue;

        [XmlElement("ControlPricePrintInOE")]
        public bool? ControlPricePrintInOE { get; set; }
        public bool ShouldSerializeControlPricePrintInOE() => ControlPricePrintInOE.HasValue;

        [XmlElement("PrintPricesOnTicket")]
        public bool? PrintPricesOnTicket { get; set; }
        public bool ShouldSerializePrintPricesOnTicket() => PrintPricesOnTicket.HasValue;

        [XmlElement("RestrictOrderstoCustomerProducts")]
        public bool? RestrictOrderstoCustomerProducts { get; set; }
        public bool ShouldSerializeRestrictOrderstoCustomerProducts() => RestrictOrderstoCustomerProducts.HasValue;

        [XmlElement("AllowAutomaticPriceAjustment")]
        public bool? AllowAutomaticPriceAjustment { get; set; }
        public bool ShouldSerializeAllowAutomaticPriceAjustment() => AllowAutomaticPriceAjustment.HasValue;
    }

    [XmlRoot(ElementName = "Charges")]
    public class CustomerCharges
    {
        [XmlElement("MinimumLoadChargeTableCode")]
        public string? MinimumLoadChargeTableCode { get; set; }
        public bool ShouldSerializeMinimumLoadChargeTableCode() => !string.IsNullOrEmpty(MinimumLoadChargeTableCode);

        [XmlElement("SeasonalChargeTableCode")]
        public string? SeasonalChargeTableCode { get; set; }
        public bool ShouldSerializeSeasonalChargeTableCode() => !string.IsNullOrEmpty(SeasonalChargeTableCode);

        [XmlElement("UnloadingChargeTableCode")]
        public string? UnloadingChargeTableCode { get; set; }
        public bool ShouldSerializeUnloadingChargeTableCode() => !string.IsNullOrEmpty(UnloadingChargeTableCode);

        [XmlElement("ApplyMinimumLoadCharge")]
        public bool? ApplyMinimumLoadCharge { get; set; }
        public bool ShouldSerializeApplyMinimumLoadCharge() => ApplyMinimumLoadCharge.HasValue;

        [XmlElement("ApplySeasonalCharge")]
        public bool? ApplySeasonalCharge { get; set; }
        public bool ShouldSerializeApplySeasonalCharge() => ApplySeasonalCharge.HasValue;

        [XmlElement("ApplyUnloadingCharge")]
        public bool? ApplyUnloadingCharge { get; set; }
        public bool ShouldSerializeApplyUnloadingCharge() => ApplyUnloadingCharge.HasValue;

        [XmlElement("PrintMinimumLoadChargeOnSeperateInvoice")]
        public bool? PrintMinimumLoadChargeOnSeperateInvoice { get; set; }
        public bool ShouldSerializePrintMinimumLoadChargeOnSeperateInvoice() => PrintMinimumLoadChargeOnSeperateInvoice.HasValue;

        [XmlElement("PrintSeasonalChargeOnSeperateInvoice")]
        public bool? PrintSeasonalChargeOnSeperateInvoice { get; set; }
        public bool ShouldSerializePrintSeasonalChargeOnSeperateInvoice() => PrintSeasonalChargeOnSeperateInvoice.HasValue;

        [XmlElement("PrintUnloadingChargeOnSeperateInvoice")]
        public bool? PrintUnloadingChargeOnSeperateInvoice { get; set; }
        public bool ShouldSerializePrintUnloadingChargeOnSeperateInvoice() => PrintUnloadingChargeOnSeperateInvoice.HasValue;

        [XmlElement("PrintAutomaticSundryChargeOnSeperateInvoice")]
        public bool? PrintAutomaticSundryChargeOnSeperateInvoice { get; set; }
        public bool ShouldSerializePrintAutomaticSundryChargeOnSeperateInvoice() => PrintAutomaticSundryChargeOnSeperateInvoice.HasValue;

        [XmlElement("SundryCharges")]
        public CustomerSundryCharges? SundryCharges { get; set; }
        public bool ShouldSerializeSundryCharges() => SundryCharges != null;
    }

    [XmlRoot(ElementName = "SundryCharges")]
    public class CustomerSundryCharges
    {
        [XmlAttribute("Method")]
        public string? Method { get; set; }

        [XmlElement("SundryCharge")]
        public List<CustomerSundryCharge>? SundryCharge { get; set; }
        public bool ShouldSerializeSundryCharge() => SundryCharge != null && SundryCharge.Count > 0;
    }

    [XmlRoot(ElementName = "SundryCharge")]
    public class CustomerSundryCharge
    {
        [XmlAttribute("Action")]
        public string? Action { get; set; }

        [XmlElement("SundryChargeID")]
        public int? SundryChargeID { get; set; }
        public bool ShouldSerializeSundryChargeID() => SundryChargeID.HasValue;

        [XmlElement("SundryChargeCode")]
        public string? SundryChargeCode { get; set; }
        public bool ShouldSerializeSundryChargeCode() => !string.IsNullOrEmpty(SundryChargeCode);

        [XmlElement("ApplySundryCharge")]
        public bool? ApplySundryCharge { get; set; }
        public bool ShouldSerializeApplySundryCharge() => ApplySundryCharge.HasValue;

        [XmlElement("Price")]
        public decimal? Price { get; set; }
        public bool ShouldSerializePrice() => Price.HasValue;

        [XmlElement("PriceUnitID")]
        public int? PriceUnitID { get; set; }
        public bool ShouldSerializePriceUnitID() => PriceUnitID.HasValue;

        [XmlElement("PriceUnitCode")]
        public string? PriceUnitCode { get; set; }
        public bool ShouldSerializePriceUnitCode() => !string.IsNullOrEmpty(PriceUnitCode);

        [XmlElement("PriceUnit")]
        public string? PriceUnit { get; set; }
        public bool ShouldSerializePriceUnit() => !string.IsNullOrEmpty(PriceUnit);

        [XmlElement("PriceExtensionCode")]
        public string? PriceExtensionCode { get; set; }
        public bool ShouldSerializePriceExtensionCode() => !string.IsNullOrEmpty(PriceExtensionCode);

        [XmlElement("EffectiveDate")]
        public DateTime? EffectiveDate { get; set; }
        public bool ShouldSerializeEffectiveDate() => EffectiveDate.HasValue;

        [XmlElement("PreviousPrice")]
        public decimal? PreviousPrice { get; set; }
        public bool ShouldSerializePreviousPrice() => PreviousPrice.HasValue;

        [XmlElement("PreviousPriceUnitID")]
        public int? PreviousPriceUnitID { get; set; }
        public bool ShouldSerializePreviousPriceUnitID() => PreviousPriceUnitID.HasValue;

        [XmlElement("PreviousPriceUnitCode")]
        public int? PreviousPriceUnitCode { get; set; }
        public bool ShouldSerializePreviousPriceUnitCode() => PreviousPriceUnitCode.HasValue;

        [XmlElement("PreviousPriceUnit")]
        public string? PreviousPriceUnit { get; set; }
        public bool ShouldSerializePreviousPriceUnit() => !string.IsNullOrEmpty(PreviousPriceUnit);

        [XmlElement("PreviousPriceExtensionCode")]
        public string? PreviousPriceExtensionCode { get; set; }
        public bool ShouldSerializePreviousPriceExtensionCode() => !string.IsNullOrEmpty(PreviousPriceExtensionCode);

        [XmlElement("CreateSeperateInvoice")]
        public bool? CreateSeperateInvoice { get; set; }
        public bool ShouldSerializeCreateSeperateInvoice() => CreateSeperateInvoice.HasValue;
    }

    [XmlRoot(ElementName = "Accounting")]
    public class CustomerAccounting
    {
        [XmlElement("StatementCycle")]
        public string? StatementCycle { get; set; }
        public bool ShouldSerializeStatementCycle() => !string.IsNullOrEmpty(StatementCycle);

        [XmlElement("AccountingCategoryCode")]
        public string? AccountingCategoryCode { get; set; }
        public bool ShouldSerializeAccountingCategoryCode() => !string.IsNullOrEmpty(AccountingCategoryCode);

        [XmlElement("ApplyFinanceCharges")]
        public bool? ApplyFinanceCharges { get; set; }
        public bool ShouldSerializeApplyFinanceCharges() => ApplyFinanceCharges.HasValue;

        [XmlElement("PrintStatements")]
        public bool? PrintStatements { get; set; }
        public bool ShouldSerializePrintStatements() => PrintStatements.HasValue;

        [XmlElement("CreditCard")]
        public CustomerCreditCard? CreditCard { get; set; }
        public bool ShouldSerializeCreditCard() => CreditCard != null;

        [XmlElement("CreditInformation")]
        public CustomerCreditInformation? CreditInformation { get; set; }
        public bool ShouldSerializeCreditInformation() => CreditInformation != null;

        [XmlElement("PurchaseOrderRequiredInOrderEntry")]
        public bool? PurchaseOrderRequiredInOrderEntry { get; set; }
        public bool ShouldSerializePurchaseOrderRequiredInOrderEntry() => PurchaseOrderRequiredInOrderEntry.HasValue;

        [XmlElement("CustomerJobRequiredInOrderEntry")]
        public bool? CustomerJobRequiredInOrderEntry { get; set; }
        public bool ShouldSerializeCustomerJobRequiredInOrderEntry() => CustomerJobRequiredInOrderEntry.HasValue;

        [XmlElement("ExternalLiensRequiredInOrderEntry")]
        public bool? ExternalLiensRequiredInOrderEntry { get; set; }
        public bool ShouldSerializeExternalLiensRequiredInOrderEntry() => ExternalLiensRequiredInOrderEntry.HasValue;

        [XmlElement("SuspendOrderReasonCode")]
        public bool? SuspendOrderReasonCode { get; set; }
        public bool ShouldSerializeSuspendOrderReasonCode() => SuspendOrderReasonCode.HasValue;

        [XmlElement("UsageCodeRequiredInOrderEntry")]
        public bool? UsageCodeRequiredInOrderEntry { get; set; }
        public bool ShouldSerializeUsageCodeRequiredInOrderEntry() => UsageCodeRequiredInOrderEntry.HasValue;
    }

    [XmlRoot(ElementName = "CreditCard")]
    public class CustomerCreditCard
    {
        [XmlElement("CardName")]
        public string? CardName { get; set; }
        public bool ShouldSerializeCardName() => !string.IsNullOrEmpty(CardName);

        [XmlElement("CardNumber")]
        public string? CardNumber { get; set; }
        public bool ShouldSerializeCardNumber() => !string.IsNullOrEmpty(CardNumber);

        [XmlElement("ResponsibleName")]
        public string? ResponsibleName { get; set; }
        public bool ShouldSerializeResponsibleName() => !string.IsNullOrEmpty(ResponsibleName);

        [XmlElement("ExpirationDate")]
        public string? ExpirationDate { get; set; }
        public bool ShouldSerializeExpirationDate() => !string.IsNullOrEmpty(ExpirationDate);
    }

    [XmlRoot(ElementName = "CreditInformation")]
    public class CustomerCreditInformation
    {
        [XmlElement("Credit")]
        public List<CustomerCredit>? Credit { get; set; }
        public bool ShouldSerializeCredit() => Credit != null && Credit.Count > 0;
    }

    [XmlRoot(ElementName = "Credit")]
    public class CustomerCredit
    {
        [XmlElement("CompanyCode")]
        public string? CompanyCode { get; set; }
        public bool ShouldSerializeCompanyCode() => !string.IsNullOrEmpty(CompanyCode);

        [XmlElement("CreditCode")]
        public string? CreditCode { get; set; }
        public bool ShouldSerializeCreditCode() => !string.IsNullOrEmpty(CreditCode);

        [XmlElement("CreditChangeDate")]
        public DateTime? CreditChangeDate { get; set; }
        public bool ShouldSerializeCreditChangeDate() => CreditChangeDate.HasValue;

        [XmlElement("CreditLimit")]
        public decimal? CreditLimit { get; set; }
        public bool ShouldSerializeCreditLimit() => CreditLimit.HasValue;

        [XmlElement("CurrentBalance")]
        public decimal? CurrentBalance { get; set; }
        public bool ShouldSerializeCurrentBalance() => CurrentBalance.HasValue;

        [XmlElement("HighBalance")]
        public decimal? HighBalance { get; set; }
        public bool ShouldSerializeHighBalance() => HighBalance.HasValue;

        [XmlElement("UpdateCredit")]
        public bool? UpdateCredit { get; set; }
        public bool ShouldSerializeUpdateCredit() => UpdateCredit.HasValue;

        [XmlElement("CreditUpdateDate")]
        public DateTime? CreditUpdateDate { get; set; }
        public bool ShouldSerializeCreditUpdateDate() => CreditUpdateDate.HasValue;

        [XmlElement("HighBalanceDate")]
        public DateTime? HighBalanceDate { get; set; }
        public bool ShouldSerializeHighBalanceDate() => HighBalanceDate.HasValue;

        [XmlElement("LastInvoiceDate")]
        public DateTime? LastInvoiceDate { get; set; }
        public bool ShouldSerializeLastInvoiceDate() => LastInvoiceDate.HasValue;

        [XmlElement("CreditPersonCode")]
        public string? CreditPersonCode { get; set; }
        public bool ShouldSerializeCreditPersonCode() => !string.IsNullOrEmpty(CreditPersonCode);

        [XmlElement("CreditPersonName")]
        public string? CreditPersonName { get; set; }
        public bool ShouldSerializeCreditPersonName() => !string.IsNullOrEmpty(CreditPersonName);
    }

    [XmlRoot(ElementName = "Distribution")]
    public class CustomerDistribution
    {
        [XmlElement("TrackingOrderColorCode")]
        public string? TrackingOrderColorCode { get; set; }
        public bool ShouldSerializeTrackingOrderColorCode() => !string.IsNullOrEmpty(TrackingOrderColorCode);

        [XmlElement("PrintMixWeightOnTicket")]
        public bool? PrintMixWeightOnTicket { get; set; }
        public bool ShouldSerializePrintMixWeightOnTicket() => PrintMixWeightOnTicket.HasValue;

        [XmlElement("PrinterSelector")]
        public string? PrinterSelector { get; set; }
        public bool ShouldSerializePrinterSelector() => !string.IsNullOrEmpty(PrinterSelector);
    }

    [XmlRoot(ElementName = "UserDefinedFields")]
    public class UserDefinedFields
    {
        [XmlAttribute("Method")]
        public string? Method { get; set; }

        [XmlElement("UserDefinedField")]
        public List<UserDefinedField>? UserDefinedField { get; set; }
        public bool ShouldSerializeUserDefinedField() => UserDefinedField != null && UserDefinedField.Count > 0;
    }

    [XmlRoot("UserDefinedField")]
    public class UserDefinedField
    {
        [XmlAttribute("Action")]
        public string? Action { get; set; }

        [XmlElement("Name")]
        public string? Name { get; set; }
        public bool ShouldSerializeName() => !string.IsNullOrEmpty(Name);

        [XmlElement("Value")]
        public string? Value { get; set; }
        public bool ShouldSerializeValue() => !string.IsNullOrEmpty(Value);
    }
}