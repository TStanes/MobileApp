using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

public partial class CommonDB_TestDbContext : DbContext
{
    public CommonDB_TestDbContext()
    {
    }

    public CommonDB_TestDbContext(DbContextOptions<CommonDB_TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountGroupM> AccountGroupMs { get; set; }

    public virtual DbSet<AccountM> AccountMs { get; set; }

    public virtual DbSet<AccountTypeM> AccountTypeMs { get; set; }

    public virtual DbSet<ActualStatusM> ActualStatusMs { get; set; }

    public virtual DbSet<AffectedAccountTypesM> AffectedAccountTypesMs { get; set; }

    public virtual DbSet<Announcement> Announcements { get; set; }

    public virtual DbSet<ApprovedVoucherDetail> ApprovedVoucherDetails { get; set; }

    public virtual DbSet<ApprovedVoucherDetailExtn> ApprovedVoucherDetailExtns { get; set; }

    public virtual DbSet<ApprovedVoucherHeader> ApprovedVoucherHeaders { get; set; }

    public virtual DbSet<ApprovedVoucherHeaderExtn> ApprovedVoucherHeaderExtns { get; set; }

    public virtual DbSet<AreaItemRate> AreaItemRates { get; set; }

    public virtual DbSet<AreaM> AreaMs { get; set; }

    public virtual DbSet<AreaSoSlno> AreaSoSlnos { get; set; }

    public virtual DbSet<AreaSoitemGroup> AreaSoitemGroups { get; set; }

    public virtual DbSet<AreaSomapping> AreaSomappings { get; set; }

    public virtual DbSet<BankM> BankMs { get; set; }

    public virtual DbSet<BatchDetail> BatchDetails { get; set; }

    public virtual DbSet<BatchSlNo> BatchSlNos { get; set; }

    public virtual DbSet<BceReimb> BceReimbs { get; set; }

    public virtual DbSet<BceaccountCheck> BceaccountChecks { get; set; }

    public virtual DbSet<BceaccountDetail> BceaccountDetails { get; set; }

    public virtual DbSet<BcedenominationDetail> BcedenominationDetails { get; set; }

    public virtual DbSet<BcerequestLevelPercentage> BcerequestLevelPercentages { get; set; }

    public virtual DbSet<Bcettccheck> Bcettcchecks { get; set; }

    public virtual DbSet<BdcollectedStatus> BdcollectedStatuses { get; set; }

    public virtual DbSet<Bdstatus> Bdstatuses { get; set; }

    public virtual DbSet<BillPassing> BillPassings { get; set; }

    public virtual DbSet<BioProductDetail> BioProductDetails { get; set; }

    public virtual DbSet<BrMasSt> BrMasSts { get; set; }

    public virtual DbSet<BrMgrBankDebitDetail> BrMgrBankDebitDetails { get; set; }

    public virtual DbSet<BranchConnectionM> BranchConnectionMs { get; set; }

    public virtual DbSet<BranchCreditNoteRegularApproval> BranchCreditNoteRegularApprovals { get; set; }

    public virtual DbSet<BranchCreditNoteRegularApproved> BranchCreditNoteRegularApproveds { get; set; }

    public virtual DbSet<BranchCreditNoteRegularRejected> BranchCreditNoteRegularRejecteds { get; set; }

    public virtual DbSet<BranchCreditNoteRegularRequest> BranchCreditNoteRegularRequests { get; set; }

    public virtual DbSet<BranchDivisionLink> BranchDivisionLinks { get; set; }

    public virtual DbSet<BranchImprest> BranchImprests { get; set; }

    public virtual DbSet<BranchItemRate> BranchItemRates { get; set; }

    public virtual DbSet<BranchLookup> BranchLookups { get; set; }

    public virtual DbSet<BranchM> BranchMs { get; set; }

    public virtual DbSet<BranchPoreceived> BranchPoreceiveds { get; set; }

    public virtual DbSet<BranchPotoReceive> BranchPotoReceives { get; set; }

    public virtual DbSet<BranchTransferReceipt> BranchTransferReceipts { get; set; }

    public virtual DbSet<BranchTransferReceiptFromBranch> BranchTransferReceiptFromBranches { get; set; }

    public virtual DbSet<BudgetM> BudgetMs { get; set; }

    public virtual DbSet<BudgetMDatum> BudgetMData { get; set; }

    public virtual DbSet<CalenderYearM> CalenderYearMs { get; set; }

    public virtual DbSet<CardSalesServiceInvoice> CardSalesServiceInvoices { get; set; }

    public virtual DbSet<CashFlowGroupM> CashFlowGroupMs { get; set; }

    public virtual DbSet<ChemicalM> ChemicalMs { get; set; }

    public virtual DbSet<ChequeBounceDetail1> ChequeBounceDetails { get; set; }

    public virtual DbSet<ChequeBounceHistory> ChequeBounceHistories { get; set; }

    public virtual DbSet<ChequeLodgementDetail> ChequeLodgementDetails { get; set; }

    public virtual DbSet<ChequeLodgementDetail1> ChequeLodgementDetails1 { get; set; }

    public virtual DbSet<ChequebounceDetail> ChequebounceDetails { get; set; }

    public virtual DbSet<CommodityCodeM> CommodityCodeMs { get; set; }

    public virtual DbSet<CompanyM> CompanyMs { get; set; }

    public virtual DbSet<ConsignmentDetail> ConsignmentDetails { get; set; }

    public virtual DbSet<ConsignmentHeader> ConsignmentHeaders { get; set; }

    public virtual DbSet<ConsolidatedMonthlyClosingstock> ConsolidatedMonthlyClosingstocks { get; set; }

    public virtual DbSet<ConsolidatedMonthlyGit> ConsolidatedMonthlyGits { get; set; }

    public virtual DbSet<ConsolidatedMonthlyJournal> ConsolidatedMonthlyJournals { get; set; }

    public virtual DbSet<ConsolidatedMonthlyLedger> ConsolidatedMonthlyLedgers { get; set; }

    public virtual DbSet<ConsolidatedMonthlyOutstandingPayable> ConsolidatedMonthlyOutstandingPayables { get; set; }

    public virtual DbSet<ConsolidatedMonthlyOutstandingReceivable> ConsolidatedMonthlyOutstandingReceivables { get; set; }

    public virtual DbSet<ConsolidatedMonthlyPurchaseProvision> ConsolidatedMonthlyPurchaseProvisions { get; set; }

    public virtual DbSet<ConsolidatedMonthlyPurchaseReturnSettlement> ConsolidatedMonthlyPurchaseReturnSettlements { get; set; }

    public virtual DbSet<ConsolidatedMonthlySalesBook> ConsolidatedMonthlySalesBooks { get; set; }

    public virtual DbSet<ConsolidatedMonthlyTaxProvision> ConsolidatedMonthlyTaxProvisions { get; set; }

    public virtual DbSet<ConsolidatedPartywiseMonthlySalesBook> ConsolidatedPartywiseMonthlySalesBooks { get; set; }

    public virtual DbSet<ConsolidatedPartywiseMonthlySalesReturnBook> ConsolidatedPartywiseMonthlySalesReturnBooks { get; set; }

    public virtual DbSet<ContractorFunctionMaster> ContractorFunctionMasters { get; set; }

    public virtual DbSet<ContractorGstaccountDetail> ContractorGstaccountDetails { get; set; }

    public virtual DbSet<ContractorRateMaster> ContractorRateMasters { get; set; }

    public virtual DbSet<ContractorTranAppDetail> ContractorTranAppDetails { get; set; }

    public virtual DbSet<ContractorTranAppHeader> ContractorTranAppHeaders { get; set; }

    public virtual DbSet<ContractorTranFnLink> ContractorTranFnLinks { get; set; }

    public virtual DbSet<ContractorTranReqDetail> ContractorTranReqDetails { get; set; }

    public virtual DbSet<ContractorTranReqHeader> ContractorTranReqHeaders { get; set; }

    public virtual DbSet<ContractorTranSubDetail> ContractorTranSubDetails { get; set; }

    public virtual DbSet<CosaepostingStatus> CosaepostingStatuses { get; set; }

    public virtual DbSet<CostTax> CostTaxes { get; set; }

    public virtual DbSet<CountryItemRate> CountryItemRates { get; set; }

    public virtual DbSet<CountryM> CountryMs { get; set; }

    public virtual DbSet<CrDrNoteInvoiceLink> CrDrNoteInvoiceLinks { get; set; }

    public virtual DbSet<CreditDaysM> CreditDaysMs { get; set; }

    public virtual DbSet<CurrencyExChangeDetail> CurrencyExChangeDetails { get; set; }

    public virtual DbSet<CurrencyM> CurrencyMs { get; set; }

    public virtual DbSet<DailyCheckedList> DailyCheckedLists { get; set; }

    public virtual DbSet<DateTimeValidation> DateTimeValidations { get; set; }

    public virtual DbSet<DealerAsset> DealerAssets { get; set; }

    public virtual DbSet<DealerBankDetail> DealerBankDetails { get; set; }

    public virtual DbSet<DealerCategoryItemRate> DealerCategoryItemRates { get; set; }

    public virtual DbSet<DealerCategoryM> DealerCategoryMs { get; set; }

    public virtual DbSet<DealerDeposit> DealerDeposits { get; set; }

    public virtual DbSet<DealerItemRate> DealerItemRates { get; set; }

    public virtual DbSet<DeletedRow> DeletedRows { get; set; }

    public virtual DbSet<DepartmentM> DepartmentMs { get; set; }

    public virtual DbSet<DepartmentalDivisionM> DepartmentalDivisionMs { get; set; }

    public virtual DbSet<DepositDetail> DepositDetails { get; set; }

    public virtual DbSet<DiccashCreditProfile> DiccashCreditProfiles { get; set; }

    public virtual DbSet<Dicfertiliter> Dicfertiliters { get; set; }

    public virtual DbSet<Dicmaster> Dicmasters { get; set; }

    public virtual DbSet<DicotherAgriInput> DicotherAgriInputs { get; set; }

    public virtual DbSet<DicpartnershipDetail> DicpartnershipDetails { get; set; }

    public virtual DbSet<Dicpesticide> Dicpesticides { get; set; }

    public virtual DbSet<Dicseed> Dicseeds { get; set; }

    public virtual DbSet<DictopBiological> DictopBiologicals { get; set; }

    public virtual DbSet<DictopCompaniesDetail> DictopCompaniesDetails { get; set; }

    public virtual DbSet<DictopCrop> DictopCrops { get; set; }

    public virtual DbSet<DictopFormulation> DictopFormulations { get; set; }

    public virtual DbSet<DictopMolecule> DictopMolecules { get; set; }

    public virtual DbSet<DictopProgresiveVillagesFarmer> DictopProgresiveVillagesFarmers { get; set; }

    public virtual DbSet<Discount4ControlM> Discount4ControlMs { get; set; }

    public virtual DbSet<DiscountItemLink> DiscountItemLinks { get; set; }

    public virtual DbSet<DiscountM> DiscountMs { get; set; }

    public virtual DbSet<DiscountMappingArea> DiscountMappingAreas { get; set; }

    public virtual DbSet<DiscountMappingBranch> DiscountMappingBranches { get; set; }

    public virtual DbSet<DiscountMappingCountry> DiscountMappingCountries { get; set; }

    public virtual DbSet<DiscountMappingDealer> DiscountMappingDealers { get; set; }

    public virtual DbSet<DiscountMappingDealerCategory> DiscountMappingDealerCategories { get; set; }

    public virtual DbSet<DiscountMappingState> DiscountMappingStates { get; set; }

    public virtual DbSet<DiscountPaymentMade> DiscountPaymentMades { get; set; }

    public virtual DbSet<DiscountPercentageallowed> DiscountPercentagealloweds { get; set; }

    public virtual DbSet<DiscountQtyLift> DiscountQtyLifts { get; set; }

    public virtual DbSet<DiscountTypeM> DiscountTypeMs { get; set; }

    public virtual DbSet<DiscountValueLift> DiscountValueLifts { get; set; }

    public virtual DbSet<DistanceChart> DistanceCharts { get; set; }

    public virtual DbSet<DivisionGroupM> DivisionGroupMs { get; set; }

    public virtual DbSet<DivisionM> DivisionMs { get; set; }

    public virtual DbSet<DivisionPrincipleM> DivisionPrincipleMs { get; set; }

    public virtual DbSet<DocumentCancellationTerm> DocumentCancellationTerms { get; set; }

    public virtual DbSet<DocumentSlNo> DocumentSlNos { get; set; }

    public virtual DbSet<DocumentSlNosAccountPosting> DocumentSlNosAccountPostings { get; set; }

    public virtual DbSet<DocumentSlNosEdsale> DocumentSlNosEdsales { get; set; }

    public virtual DbSet<DocumentSlNosSale> DocumentSlNosSales { get; set; }

    public virtual DbSet<DocumentSlNosStockTransfer> DocumentSlNosStockTransfers { get; set; }

    public virtual DbSet<DrCrCodeSelect> DrCrCodeSelects { get; set; }

    public virtual DbSet<DrcrcodeSelectLink> DrcrcodeSelectLinks { get; set; }

    public virtual DbSet<DrcrnoteHoapproved> DrcrnoteHoapproveds { get; set; }

    public virtual DbSet<DrcrnoteHotoApprove> DrcrnoteHotoApproves { get; set; }

    public virtual DbSet<EdCharge> EdCharges { get; set; }

    public virtual DbSet<EdchargesM> EdchargesMs { get; set; }

    public virtual DbSet<Edmaster> Edmasters { get; set; }

    public virtual DbSet<Edsissue> Edsissues { get; set; }

    public virtual DbSet<EdsqtyCalculationTable> EdsqtyCalculationTables { get; set; }

    public virtual DbSet<Edsreceipt> Edsreceipts { get; set; }

    public virtual DbSet<EinvoiceBankinfo> EinvoiceBankinfos { get; set; }

    public virtual DbSet<EinvoiceDataM> EinvoiceDataMs { get; set; }

    public virtual DbSet<EjvacknoUpdation> EjvacknoUpdations { get; set; }

    public virtual DbSet<EjvchallanUpdate> EjvchallanUpdates { get; set; }

    public virtual DbSet<EjvvoucherUpdation> EjvvoucherUpdations { get; set; }

    public virtual DbSet<EmployeeAnnualLeaveM> EmployeeAnnualLeaveMs { get; set; }

    public virtual DbSet<EmployeeLeaveDetail> EmployeeLeaveDetails { get; set; }

    public virtual DbSet<EnquiryM> EnquiryMs { get; set; }

    public virtual DbSet<EwaybillDataM> EwaybillDataMs { get; set; }

    public virtual DbSet<FarmersM> FarmersMs { get; set; }

    public virtual DbSet<FekycmasterM> FekycmasterMs { get; set; }

    public virtual DbSet<FekycrequestM> FekycrequestMs { get; set; }

    public virtual DbSet<FieldInspectionReportM> FieldInspectionReportMs { get; set; }

    public virtual DbSet<FinancialYear> FinancialYears { get; set; }

    public virtual DbSet<FinancialYearM> FinancialYearMs { get; set; }

    public virtual DbSet<FnVhrInvOldDelTbl> FnVhrInvOldDelTbls { get; set; }

    public virtual DbSet<FollowUpDetail> FollowUpDetails { get; set; }

    public virtual DbSet<FormFentry> FormFentries { get; set; }

    public virtual DbSet<FreeItemM> FreeItemMs { get; set; }

    public virtual DbSet<FreeItemQty> FreeItemQties { get; set; }

    public virtual DbSet<FreeTransLink> FreeTransLinks { get; set; }

    public virtual DbSet<FreightChargesM> FreightChargesMs { get; set; }

    public virtual DbSet<FrieghtPaymentTypeM> FrieghtPaymentTypeMs { get; set; }

    public virtual DbSet<FrtCharge> FrtCharges { get; set; }

    public virtual DbSet<GeneralLedgerView> GeneralLedgerViews { get; set; }

    public virtual DbSet<GlcategoryM> GlcategoryMs { get; set; }

    public virtual DbSet<GlpostingStatusM> GlpostingStatusMs { get; set; }

    public virtual DbSet<GracePeriodForBackDaysEntry> GracePeriodForBackDaysEntries { get; set; }

    public virtual DbSet<Grnamendment> Grnamendments { get; set; }

    public virtual DbSet<GrncashPurchaseItemM> GrncashPurchaseItemMs { get; set; }

    public virtual DbSet<GrnoutsourceMapping> GrnoutsourceMappings { get; set; }

    public virtual DbSet<GrossMarginEdvatMappingM> GrossMarginEdvatMappingMs { get; set; }

    public virtual DbSet<GroupHeadEntry> GroupHeadEntries { get; set; }

    public virtual DbSet<GstexpDetail> GstexpDetails { get; set; }

    public virtual DbSet<HelpM> HelpMs { get; set; }

    public virtual DbSet<HoapprovedDrcrnote> HoapprovedDrcrnotes { get; set; }

    public virtual DbSet<Hoapprovedatum> Hoapprovedata { get; set; }

    public virtual DbSet<Hostvddec> Hostvddecs { get; set; }

    public virtual DbSet<Hostvdnov> Hostvdnovs { get; set; }

    public virtual DbSet<Hostvhenov> Hostvhenovs { get; set; }

    public virtual DbSet<Hostvhnov> Hostvhnovs { get; set; }

    public virtual DbSet<HotoApproveDatum> HotoApproveData { get; set; }

    public virtual DbSet<HsnaccountMappingM> HsnaccountMappingMs { get; set; }

    public virtual DbSet<HsncodeM> HsncodeMs { get; set; }

    public virtual DbSet<IbtaccountSync> IbtaccountSyncs { get; set; }

    public virtual DbSet<InOutRegisterMfNew> InOutRegisterMfNews { get; set; }

    public virtual DbSet<InOutRegisterNew> InOutRegisterNews { get; set; }

    public virtual DbSet<IndexMaintenanceHistory> IndexMaintenanceHistories { get; set; }

    public virtual DbSet<Inoutregister> Inoutregisters { get; set; }

    public virtual DbSet<Inoutregistermf> Inoutregistermfs { get; set; }

    public virtual DbSet<Inoutregistermfmirror> Inoutregistermfmirrors { get; set; }

    public virtual DbSet<Inoutregistermirror> Inoutregistermirrors { get; set; }

    public virtual DbSet<InventoryServiceTran> InventoryServiceTrans { get; set; }

    public virtual DbSet<InventoryServiceTransList> InventoryServiceTransLists { get; set; }

    public virtual DbSet<InventoryTran> InventoryTrans { get; set; }

    public virtual DbSet<InventoryTransExtn> InventoryTransExtns { get; set; }

    public virtual DbSet<InventoryTransList> InventoryTransLists { get; set; }

    public virtual DbSet<InventoryTransListExtn> InventoryTransListExtns { get; set; }

    public virtual DbSet<InventoryTransRequestSlNo> InventoryTransRequestSlNos { get; set; }

    public virtual DbSet<IssueReportingM> IssueReportingMs { get; set; }

    public virtual DbSet<ItemCategoryM> ItemCategoryMs { get; set; }

    public virtual DbSet<ItemCodeSlno> ItemCodeSlnos { get; set; }

    public virtual DbSet<ItemCommodity> ItemCommodities { get; set; }

    public virtual DbSet<ItemDivisionLink> ItemDivisionLinks { get; set; }

    public virtual DbSet<ItemDivisionPrincipleLink> ItemDivisionPrincipleLinks { get; set; }

    public virtual DbSet<ItemGroupM> ItemGroupMs { get; set; }

    public virtual DbSet<ItemGroupSubGroupMappingForReport> ItemGroupSubGroupMappingForReports { get; set; }

    public virtual DbSet<ItemInterested> ItemInteresteds { get; set; }

    public virtual DbSet<ItemM> ItemMs { get; set; }

    public virtual DbSet<ItemMasterM> ItemMasterMs { get; set; }

    public virtual DbSet<ItemPrincipleSerialNoLink> ItemPrincipleSerialNoLinks { get; set; }

    public virtual DbSet<ItemRate> ItemRates { get; set; }

    public virtual DbSet<ItemRateHeader> ItemRateHeaders { get; set; }

    public virtual DbSet<ItemRateTypeM> ItemRateTypeMs { get; set; }

    public virtual DbSet<ItemRequestPack> ItemRequestPacks { get; set; }

    public virtual DbSet<ItemRequestRejection> ItemRequestRejections { get; set; }

    public virtual DbSet<ItemRequestSlNo> ItemRequestSlNos { get; set; }

    public virtual DbSet<ItemSeedM> ItemSeedMs { get; set; }

    public virtual DbSet<ItemSegmentM> ItemSegmentMs { get; set; }

    public virtual DbSet<ItemSpecificationM> ItemSpecificationMs { get; set; }

    public virtual DbSet<ItemStatusM> ItemStatusMs { get; set; }

    public virtual DbSet<ItemStatusPhyCertM> ItemStatusPhyCertMs { get; set; }

    public virtual DbSet<ItemSubGroupM> ItemSubGroupMs { get; set; }

    public virtual DbSet<ItemSupplierLink> ItemSupplierLinks { get; set; }

    public virtual DbSet<ItemWiseSalesOrderLink> ItemWiseSalesOrderLinks { get; set; }

    public virtual DbSet<ItemWiseStorageDetail> ItemWiseStorageDetails { get; set; }

    public virtual DbSet<ItsectionM> ItsectionMs { get; set; }

    public virtual DbSet<LeaveTypeM> LeaveTypeMs { get; set; }

    public virtual DbSet<LedgerTemplateMappingM> LedgerTemplateMappingMs { get; set; }

    public virtual DbSet<LedgerTemplatesM> LedgerTemplatesMs { get; set; }

    public virtual DbSet<LiveMonthYear> LiveMonthYears { get; set; }

    public virtual DbSet<LockNewSoba> LockNewSobas { get; set; }

    public virtual DbSet<MItemRateHeaderDtChange> MItemRateHeaderDtChanges { get; set; }

    public virtual DbSet<MenusM> MenusMs { get; set; }

    public virtual DbSet<MonthEndProcedureM> MonthEndProcedureMs { get; set; }

    public virtual DbSet<MonthendProcedureCheckList> MonthendProcedureCheckLists { get; set; }

    public virtual DbSet<MonthlyClosingMovingAverage> MonthlyClosingMovingAverages { get; set; }

    public virtual DbSet<Moqm> Moqms { get; set; }

    public virtual DbSet<OneTimeAddress> OneTimeAddresses { get; set; }

    public virtual DbSet<OpeningRatesCipd> OpeningRatesCipds { get; set; }

    public virtual DbSet<OverdueDaysM> OverdueDaysMs { get; set; }

    public virtual DbSet<PackM> PackMs { get; set; }

    public virtual DbSet<PackingM> PackingMs { get; set; }

    public virtual DbSet<ParentDivisionMappingM> ParentDivisionMappingMs { get; set; }

    public virtual DbSet<PartiesM> PartiesMs { get; set; }

    public virtual DbSet<PartyAddressDetailsBranchRequest> PartyAddressDetailsBranchRequests { get; set; }

    public virtual DbSet<PartyAddressDetailsHoapproval> PartyAddressDetailsHoapprovals { get; set; }

    public virtual DbSet<PartyBankDetailsBranchRequest> PartyBankDetailsBranchRequests { get; set; }

    public virtual DbSet<PartyBankDetailsHoapproval> PartyBankDetailsHoapprovals { get; set; }

    public virtual DbSet<PartyCodeSlNo> PartyCodeSlNos { get; set; }

    public virtual DbSet<PartyCreditLimitBranchRequest> PartyCreditLimitBranchRequests { get; set; }

    public virtual DbSet<PartyCreditLimitHistory> PartyCreditLimitHistories { get; set; }

    public virtual DbSet<PartyCreditLimitHoapproval> PartyCreditLimitHoapprovals { get; set; }

    public virtual DbSet<PartyCreditLimitM> PartyCreditLimitMs { get; set; }

    public virtual DbSet<PartyCreditLimitMApdissue> PartyCreditLimitMApdissues { get; set; }

    public virtual DbSet<PartyM> PartyMs { get; set; }

    public virtual DbSet<PartyModificationRequestSlNo> PartyModificationRequestSlNos { get; set; }

    public virtual DbSet<PartyOtherDetailsBranchRequest> PartyOtherDetailsBranchRequests { get; set; }

    public virtual DbSet<PartyOtherDetailsHoapproval> PartyOtherDetailsHoapprovals { get; set; }

    public virtual DbSet<PartyRequestSlNo> PartyRequestSlNos { get; set; }

    public virtual DbSet<PartyShipTo> PartyShipTos { get; set; }

    public virtual DbSet<PartyTypeM> PartyTypeMs { get; set; }

    public virtual DbSet<PayModeM> PayModeMs { get; set; }

    public virtual DbSet<PcrcancelledDetail> PcrcancelledDetails { get; set; }

    public virtual DbSet<Pcrdetail> Pcrdetails { get; set; }

    public virtual DbSet<PeriodicalDiscountExemptedM> PeriodicalDiscountExemptedMs { get; set; }

    public virtual DbSet<PhysicalStockVerificationDetail> PhysicalStockVerificationDetails { get; set; }

    public virtual DbSet<PhysicalStockVerificationEntryDetail> PhysicalStockVerificationEntryDetails { get; set; }

    public virtual DbSet<PhysicalStockVerificationEntryHeader> PhysicalStockVerificationEntryHeaders { get; set; }

    public virtual DbSet<PhysicalStockVerificationHeader> PhysicalStockVerificationHeaders { get; set; }

    public virtual DbSet<Podetail> Podetails { get; set; }

    public virtual DbSet<Poheader> Poheaders { get; set; }

    public virtual DbSet<Poindent> Poindents { get; set; }

    public virtual DbSet<Poschedule> Poschedules { get; set; }

    public virtual DbSet<PreDefinedIndentQuery> PreDefinedIndentQueries { get; set; }

    public virtual DbSet<PreferredDealerM> PreferredDealerMs { get; set; }

    public virtual DbSet<PriceDiscountControlM> PriceDiscountControlMs { get; set; }

    public virtual DbSet<PrincDecl> PrincDecls { get; set; }

    public virtual DbSet<PrincipleSerialNumber> PrincipleSerialNumbers { get; set; }

    public virtual DbSet<PrintM> PrintMs { get; set; }

    public virtual DbSet<ProcessChargesM> ProcessChargesMs { get; set; }

    public virtual DbSet<ProcessInformation> ProcessInformations { get; set; }

    public virtual DbSet<ProcessedPeriodicalSchemeCreditNote> ProcessedPeriodicalSchemeCreditNotes { get; set; }

    public virtual DbSet<ProductPromotionPaymentApproval> ProductPromotionPaymentApprovals { get; set; }

    public virtual DbSet<ProductPromotionPaymentRequestM> ProductPromotionPaymentRequestMs { get; set; }

    public virtual DbSet<ProductionBatchBom> ProductionBatchBoms { get; set; }

    public virtual DbSet<ProductionItemRanking> ProductionItemRankings { get; set; }

    public virtual DbSet<ProductionLoss> ProductionLosses { get; set; }

    public virtual DbSet<ProductionM> ProductionMs { get; set; }

    public virtual DbSet<ProductionQrcodeItemDetail> ProductionQrcodeItemDetails { get; set; }

    public virtual DbSet<ProductionQrcodeList> ProductionQrcodeLists { get; set; }

    public virtual DbSet<ProformaInvoiceDetail> ProformaInvoiceDetails { get; set; }

    public virtual DbSet<ProformaInvoiceHeader> ProformaInvoiceHeaders { get; set; }

    public virtual DbSet<ProvisionReverse> ProvisionReverses { get; set; }

    public virtual DbSet<ProvisionalSchemeCreditNote> ProvisionalSchemeCreditNotes { get; set; }

    public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }

    public virtual DbSet<PurchaseInvoiceDetailConsignment> PurchaseInvoiceDetailConsignments { get; set; }

    public virtual DbSet<PurchaseInvoiceDetailExtn> PurchaseInvoiceDetailExtns { get; set; }

    public virtual DbSet<PurchaseInvoiceHeader> PurchaseInvoiceHeaders { get; set; }

    public virtual DbSet<PurchaseInvoiceHeaderExtn> PurchaseInvoiceHeaderExtns { get; set; }

    public virtual DbSet<PurchaseMode> PurchaseModes { get; set; }

    public virtual DbSet<PurchaseOrderAdvance> PurchaseOrderAdvances { get; set; }

    public virtual DbSet<PurchaseOrderAdvanceAdjustment> PurchaseOrderAdvanceAdjustments { get; set; }

    public virtual DbSet<QtyAdjInfo> QtyAdjInfos { get; set; }

    public virtual DbSet<QuarterM> QuarterMs { get; set; }

    public virtual DbSet<RDivisionwiseTrialBalance> RDivisionwiseTrialBalances { get; set; }

    public virtual DbSet<ROverHeadAnalysis> ROverHeadAnalyses { get; set; }

    public virtual DbSet<ROverHeadAnalysisOtherAccount> ROverHeadAnalysisOtherAccounts { get; set; }

    public virtual DbSet<ROverHeadAnalysisSale> ROverHeadAnalysisSales { get; set; }

    public virtual DbSet<ROverheadServiceDivAllocation> ROverheadServiceDivAllocations { get; set; }

    public virtual DbSet<RateLogicHdr> RateLogicHdrs { get; set; }

    public virtual DbSet<RateLogicItemSubGroupLink> RateLogicItemSubGroupLinks { get; set; }

    public virtual DbSet<RateLogicMappingAreaItemSubGroup> RateLogicMappingAreaItemSubGroups { get; set; }

    public virtual DbSet<RateLogicMappingBranchItemSubGroup> RateLogicMappingBranchItemSubGroups { get; set; }

    public virtual DbSet<RateTypeM> RateTypeMs { get; set; }

    public virtual DbSet<RegistrationM> RegistrationMs { get; set; }

    public virtual DbSet<RejectedDealerAsset> RejectedDealerAssets { get; set; }

    public virtual DbSet<RejectedDealerBankDetail> RejectedDealerBankDetails { get; set; }

    public virtual DbSet<RejectedDealerDeposit> RejectedDealerDeposits { get; set; }

    public virtual DbSet<RejectedInventoryTran> RejectedInventoryTrans { get; set; }

    public virtual DbSet<RejectedInventoryTransList> RejectedInventoryTransLists { get; set; }

    public virtual DbSet<RejectedItemDivisionLink> RejectedItemDivisionLinks { get; set; }

    public virtual DbSet<RejectedItemDivisionPrincipleLink> RejectedItemDivisionPrincipleLinks { get; set; }

    public virtual DbSet<RejectedItemM> RejectedItemMs { get; set; }

    public virtual DbSet<RejectedItemRequestPack> RejectedItemRequestPacks { get; set; }

    public virtual DbSet<RejectedPartyCreditLimitM> RejectedPartyCreditLimitMs { get; set; }

    public virtual DbSet<RejectedPartyM> RejectedPartyMs { get; set; }

    public virtual DbSet<RejectedPartyShipTo> RejectedPartyShipTos { get; set; }

    public virtual DbSet<ReplicationLog> ReplicationLogs { get; set; }

    public virtual DbSet<ReplicationLogToBranchFromSync> ReplicationLogToBranchFromSyncs { get; set; }

    public virtual DbSet<ReplicationLogToCommonFromSync> ReplicationLogToCommonFromSyncs { get; set; }

    public virtual DbSet<ReplicationLogToHo> ReplicationLogToHos { get; set; }

    public virtual DbSet<ReplicationLogToSyncFromBranch> ReplicationLogToSyncFromBranches { get; set; }

    public virtual DbSet<ReplicationLogToSyncFromCommon> ReplicationLogToSyncFromCommons { get; set; }

    public virtual DbSet<ReportAccountCodelink> ReportAccountCodelinks { get; set; }

    public virtual DbSet<RequestDealerAsset> RequestDealerAssets { get; set; }

    public virtual DbSet<RequestDealerBankDetail> RequestDealerBankDetails { get; set; }

    public virtual DbSet<RequestDealerDeposit> RequestDealerDeposits { get; set; }

    public virtual DbSet<RequestItemDivisionLink> RequestItemDivisionLinks { get; set; }

    public virtual DbSet<RequestItemM> RequestItemMs { get; set; }

    public virtual DbSet<RequestItemRequestPack> RequestItemRequestPacks { get; set; }

    public virtual DbSet<RequestPartyCreditLimitM> RequestPartyCreditLimitMs { get; set; }

    public virtual DbSet<RequestPartyM> RequestPartyMs { get; set; }

    public virtual DbSet<RequestPartyShipTo> RequestPartyShipTos { get; set; }

    public virtual DbSet<RequestVoucherDetail> RequestVoucherDetails { get; set; }

    public virtual DbSet<RequestVoucherDetailExtn> RequestVoucherDetailExtns { get; set; }

    public virtual DbSet<RequestVoucherHeader> RequestVoucherHeaders { get; set; }

    public virtual DbSet<RequestVoucherHeaderExtn> RequestVoucherHeaderExtns { get; set; }

    public virtual DbSet<RollingForeCastM> RollingForeCastMs { get; set; }

    public virtual DbSet<RollingForeCastMDatum> RollingForeCastMData { get; set; }

    public virtual DbSet<RspItemProfile> RspItemProfiles { get; set; }

    public virtual DbSet<SalaryPosting> SalaryPostings { get; set; }

    public virtual DbSet<SalaryandFdposting> SalaryandFdpostings { get; set; }

    public virtual DbSet<SalesOfficerM> SalesOfficerMs { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual DbSet<SalesOrderForMobile> SalesOrderForMobiles { get; set; }

    public virtual DbSet<SalesOrderFromApp> SalesOrderFromApps { get; set; }

    public virtual DbSet<SalesOrderHdr> SalesOrderHdrs { get; set; }

    public virtual DbSet<Schedule6GroupM> Schedule6GroupMs { get; set; }

    public virtual DbSet<ScheduleTypeM> ScheduleTypeMs { get; set; }

    public virtual DbSet<SchemeCnbranchRequest> SchemeCnbranchRequests { get; set; }

    public virtual DbSet<SchemeCreditNoteApprovalDoc> SchemeCreditNoteApprovalDocs { get; set; }

    public virtual DbSet<SchemeGeneration> SchemeGenerations { get; set; }

    public virtual DbSet<SecSupplierCodeSlno> SecSupplierCodeSlnos { get; set; }

    public virtual DbSet<SecondarySupplierM> SecondarySupplierMs { get; set; }

    public virtual DbSet<SeedCategoryM> SeedCategoryMs { get; set; }

    public virtual DbSet<SeedGovtDetail> SeedGovtDetails { get; set; }

    public virtual DbSet<SeedTypeM> SeedTypeMs { get; set; }

    public virtual DbSet<SeedVarietyM> SeedVarietyMs { get; set; }

    public virtual DbSet<SelectMonthName> SelectMonthNames { get; set; }

    public virtual DbSet<ServerDateTimeValidation> ServerDateTimeValidations { get; set; }

    public virtual DbSet<ShoeSize> ShoeSizes { get; set; }

    public virtual DbSet<SingleInvoiceTradeDiscountExemptedM> SingleInvoiceTradeDiscountExemptedMs { get; set; }

    public virtual DbSet<Soamendment> Soamendments { get; set; }

    public virtual DbSet<Sodetail> Sodetails { get; set; }

    public virtual DbSet<SoforwardBranch> SoforwardBranches { get; set; }

    public virtual DbSet<Soheader> Soheaders { get; set; }

    public virtual DbSet<SoheaderHoapproved> SoheaderHoapproveds { get; set; }

    public virtual DbSet<SoheaderHoapprovedOld> SoheaderHoapprovedOlds { get; set; }

    public virtual DbSet<SowingReportM> SowingReportMs { get; set; }

    public virtual DbSet<StDecl> StDecls { get; set; }

    public virtual DbSet<StanesPesticidesDetail> StanesPesticidesDetails { get; set; }

    public virtual DbSet<StanesSsisjob> StanesSsisjobs { get; set; }

    public virtual DbSet<StateCommodityM> StateCommodityMs { get; set; }

    public virtual DbSet<StateDistrictMappingM> StateDistrictMappingMs { get; set; }

    public virtual DbSet<StateItemRate> StateItemRates { get; set; }

    public virtual DbSet<StateM> StateMs { get; set; }

    public virtual DbSet<StateM1> StateMs1 { get; set; }

    public virtual DbSet<StateMf> StateMfs { get; set; }

    public virtual DbSet<Statement507ReportParty> Statement507ReportParties { get; set; }

    public virtual DbSet<StatewiseVatclaim> StatewiseVatclaims { get; set; }

    public virtual DbSet<StatusM> StatusMs { get; set; }

    public virtual DbSet<StockPointCommisionAccountMapping> StockPointCommisionAccountMappings { get; set; }

    public virtual DbSet<StockPointCommisionInventoryLink> StockPointCommisionInventoryLinks { get; set; }

    public virtual DbSet<StockPointCommisionM> StockPointCommisionMs { get; set; }

    public virtual DbSet<StockPointCommissionDetail> StockPointCommissionDetails { get; set; }

    public virtual DbSet<StockPointCommissionDetailNew> StockPointCommissionDetailNews { get; set; }

    public virtual DbSet<StockPointCommissionMNew> StockPointCommissionMNews { get; set; }

    public virtual DbSet<StockPointDealerMapping> StockPointDealerMappings { get; set; }

    public virtual DbSet<StockSnoM> StockSnoMs { get; set; }

    public virtual DbSet<StockTransferReceiptRemovalLink> StockTransferReceiptRemovalLinks { get; set; }

    public virtual DbSet<StorageLocationM> StorageLocationMs { get; set; }

    public virtual DbSet<SupVoucherMatch> SupVoucherMatches { get; set; }

    public virtual DbSet<SupplierCodeSlNo> SupplierCodeSlNos { get; set; }

    public virtual DbSet<SupplierControlCodeM> SupplierControlCodeMs { get; set; }

    public virtual DbSet<SupplierDeliveryMode> SupplierDeliveryModes { get; set; }

    public virtual DbSet<SurveyBasalFertilizer> SurveyBasalFertilizers { get; set; }

    public virtual DbSet<SurveyMicroNutrient> SurveyMicroNutrients { get; set; }

    public virtual DbSet<SurveyPesticide> SurveyPesticides { get; set; }

    public virtual DbSet<SurveyQuestionnare> SurveyQuestionnares { get; set; }

    public virtual DbSet<SurveyTopDressing> SurveyTopDressings { get; set; }

    public virtual DbSet<SyncDblist> SyncDblists { get; set; }

    public virtual DbSet<SyncFlagList> SyncFlagLists { get; set; }

    public virtual DbSet<SyncStatus> SyncStatuses { get; set; }

    public virtual DbSet<SyncTableList> SyncTableLists { get; set; }

    public virtual DbSet<SyncTableListToHo> SyncTableListToHos { get; set; }

    public virtual DbSet<SyncTimerList> SyncTimerLists { get; set; }

    public virtual DbSet<SynchronizObject> SynchronizObjects { get; set; }

    public virtual DbSet<TabillApproval> TabillApprovals { get; set; }

    public virtual DbSet<TabillDeduction> TabillDeductions { get; set; }

    public virtual DbSet<TabillManualReceived> TabillManualReceiveds { get; set; }

    public virtual DbSet<TabillRequest> TabillRequests { get; set; }

    public virtual DbSet<TaempSubM> TaempSubMs { get; set; }

    public virtual DbSet<TaemployeeM> TaemployeeMs { get; set; }

    public virtual DbSet<TargetFixM> TargetFixMs { get; set; }

    public virtual DbSet<TargetM> TargetMs { get; set; }

    public virtual DbSet<TaxExemptedItemMaster> TaxExemptedItemMasters { get; set; }

    public virtual DbSet<TaxM> TaxMs { get; set; }

    public virtual DbSet<TaxMdetail> TaxMdetails { get; set; }

    public virtual DbSet<TaxTypeM> TaxTypeMs { get; set; }

    public virtual DbSet<TempBulkUpdatePartyCreditDay> TempBulkUpdatePartyCreditDays { get; set; }

    public virtual DbSet<TempExportItem> TempExportItems { get; set; }

    public virtual DbSet<TrailBalance> TrailBalances { get; set; }

    public virtual DbSet<TransactionSlNo> TransactionSlNos { get; set; }

    public virtual DbSet<TransactionTypeConfiguration> TransactionTypeConfigurations { get; set; }

    public virtual DbSet<TransactionTypePurposeDetailM> TransactionTypePurposeDetailMs { get; set; }

    public virtual DbSet<TransactionTypePurposeHeaderM> TransactionTypePurposeHeaderMs { get; set; }

    public virtual DbSet<TransactionTypePurposeLinkM> TransactionTypePurposeLinkMs { get; set; }

    public virtual DbSet<TransactionTypesM> TransactionTypesMs { get; set; }

    public virtual DbSet<Tt148Chbh24042025> Tt148Chbh24042025s { get; set; }

    public virtual DbSet<TtVml14809072025> TtVml14809072025s { get; set; }

    public virtual DbSet<Ttcbranch> Ttcbranches { get; set; }

    public virtual DbSet<Ttccategory> Ttccategories { get; set; }

    public virtual DbSet<Ttccheck> Ttcchecks { get; set; }

    public virtual DbSet<Ttcdivision> Ttcdivisions { get; set; }

    public virtual DbSet<Ttcstate> Ttcstates { get; set; }

    public virtual DbSet<TtcsubGroup> TtcsubGroups { get; set; }

    public virtual DbSet<TyreM> TyreMs { get; set; }

    public virtual DbSet<TyreRetreadingAttendedByM> TyreRetreadingAttendedByMs { get; set; }

    public virtual DbSet<UnAdjustedCredit> UnAdjustedCredits { get; set; }

    public virtual DbSet<UnAdjustedDebit> UnAdjustedDebits { get; set; }

    public virtual DbSet<Uomm> Uomms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserBranchMapping> UserBranchMappings { get; set; }

    public virtual DbSet<UserGroupDivisionMappingM> UserGroupDivisionMappingMs { get; set; }

    public virtual DbSet<UserGroupM> UserGroupMs { get; set; }

    public virtual DbSet<UserMaster> UserMasters { get; set; }

    public virtual DbSet<UserRight> UserRights { get; set; }

    public virtual DbSet<UserRightsWebApplication> UserRightsWebApplications { get; set; }

    public virtual DbSet<UserTypeLink> UserTypeLinks { get; set; }

    public virtual DbSet<UserTypeM> UserTypeMs { get; set; }

    public virtual DbSet<VatnotConsideredGroup> VatnotConsideredGroups { get; set; }

    public virtual DbSet<VechicleM> VechicleMs { get; set; }

    public virtual DbSet<VechicleTran> VechicleTrans { get; set; }

    public virtual DbSet<VehicleReimbursementDetail> VehicleReimbursementDetails { get; set; }

    public virtual DbSet<VehicleReimbursementM> VehicleReimbursementMs { get; set; }

    public virtual DbSet<VendorMappingM> VendorMappingMs { get; set; }

    public virtual DbSet<VerficationCodeM> VerficationCodeMs { get; set; }

    public virtual DbSet<VersionM> VersionMs { get; set; }

    public virtual DbSet<VersionMHistory> VersionMHistories { get; set; }

    public virtual DbSet<VersionUpdate> VersionUpdates { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }

    public virtual DbSet<VoucherDetailExtn> VoucherDetailExtns { get; set; }

    public virtual DbSet<VoucherDetailFreightExtn> VoucherDetailFreightExtns { get; set; }

    public virtual DbSet<VoucherDetailToBranch> VoucherDetailToBranches { get; set; }

    public virtual DbSet<VoucherHeader> VoucherHeaders { get; set; }

    public virtual DbSet<VoucherHeaderExtn> VoucherHeaderExtns { get; set; }

    public virtual DbSet<VoucherHoapproved> VoucherHoapproveds { get; set; }

    public virtual DbSet<VoucherHotoApprove> VoucherHotoApproves { get; set; }

    public virtual DbSet<VoucherMatch> VoucherMatches { get; set; }

    public virtual DbSet<VoucherMatchLink> VoucherMatchLinks { get; set; }

    public virtual DbSet<VoucherSchemeDetail> VoucherSchemeDetails { get; set; }

    public virtual DbSet<VouchermatchBk> VouchermatchBks { get; set; }

    public virtual DbSet<VouchermatchlinkBk> VouchermatchlinkBks { get; set; }

    public virtual DbSet<VwApprovedVoucher> VwApprovedVouchers { get; set; }

    public virtual DbSet<VwAwaitingHoapproval> VwAwaitingHoapprovals { get; set; }

    public virtual DbSet<VwBatch> VwBatches { get; set; }

    public virtual DbSet<VwBatchdetail> VwBatchdetails { get; set; }

    public virtual DbSet<VwBceSum1> VwBceSum1s { get; set; }

    public virtual DbSet<VwChequeLodgementDetail> VwChequeLodgementDetails { get; set; }

    public virtual DbSet<VwChqDebitDet> VwChqDebitDets { get; set; }

    public virtual DbSet<VwChqRealDet> VwChqRealDets { get; set; }

    public virtual DbSet<VwChqbCr> VwChqbCrs { get; set; }

    public virtual DbSet<VwClosingStock> VwClosingStocks { get; set; }

    public virtual DbSet<VwCommodityMaster> VwCommodityMasters { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyClosingstock> VwConsolidatedMonthlyClosingstocks { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyGit> VwConsolidatedMonthlyGits { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyJournal> VwConsolidatedMonthlyJournals { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyLedger> VwConsolidatedMonthlyLedgers { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyOutstandingPayable> VwConsolidatedMonthlyOutstandingPayables { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyOutstandingReceivable> VwConsolidatedMonthlyOutstandingReceivables { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyPurchaseProvision> VwConsolidatedMonthlyPurchaseProvisions { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyPurchaseReturnSettlement> VwConsolidatedMonthlyPurchaseReturnSettlements { get; set; }

    public virtual DbSet<VwConsolidatedMonthlySalesBook> VwConsolidatedMonthlySalesBooks { get; set; }

    public virtual DbSet<VwConsolidatedMonthlyTaxProvision> VwConsolidatedMonthlyTaxProvisions { get; set; }

    public virtual DbSet<VwConsolidatedPartywiseMonthlySalesBook> VwConsolidatedPartywiseMonthlySalesBooks { get; set; }

    public virtual DbSet<VwConsolidatedPartywiseMonthlySalesReturnBook> VwConsolidatedPartywiseMonthlySalesReturnBooks { get; set; }

    public virtual DbSet<VwCreditOutStanding> VwCreditOutStandings { get; set; }

    public virtual DbSet<VwCreditnoteFinal> VwCreditnoteFinals { get; set; }

    public virtual DbSet<VwCrlimitDivisionprinciple> VwCrlimitDivisionprinciples { get; set; }

    public virtual DbSet<VwCrlmt> VwCrlmts { get; set; }

    public virtual DbSet<VwDebitOutStanding> VwDebitOutStandings { get; set; }

    public virtual DbSet<VwDebitnoteFinal> VwDebitnoteFinals { get; set; }

    public virtual DbSet<VwDespdetail> VwDespdetails { get; set; }

    public virtual DbSet<VwDetailsOfStockTransferIssue> VwDetailsOfStockTransferIssues { get; set; }

    public virtual DbSet<VwDetailsOfStockTransferReceived> VwDetailsOfStockTransferReceiveds { get; set; }

    public virtual DbSet<VwDetailsofPurchaseReturn> VwDetailsofPurchaseReturns { get; set; }

    public virtual DbSet<VwDetailsofPurchaseUpLoad> VwDetailsofPurchaseUpLoads { get; set; }

    public virtual DbSet<VwDetailsofSalesReturn> VwDetailsofSalesReturns { get; set; }

    public virtual DbSet<VwDetailsofSalesUpLoad> VwDetailsofSalesUpLoads { get; set; }

    public virtual DbSet<VwDiscountItemDetail> VwDiscountItemDetails { get; set; }

    public virtual DbSet<VwDlyCashComb> VwDlyCashCombs { get; set; }

    public virtual DbSet<VwEdsReceipt> VwEdsReceipts { get; set; }

    public virtual DbSet<VwEdsTransaction> VwEdsTransactions { get; set; }

    public virtual DbSet<VwFicsal> VwFicsals { get; set; }

    public virtual DbSet<VwFicsalFinal> VwFicsalFinals { get; set; }

    public virtual DbSet<VwFinancialYearM> VwFinancialYearMs { get; set; }

    public virtual DbSet<VwInvFinal> VwInvFinals { get; set; }

    public virtual DbSet<VwInvHead> VwInvHeads { get; set; }

    public virtual DbSet<VwInvList> VwInvLists { get; set; }

    public virtual DbSet<VwInventory> VwInventories { get; set; }

    public virtual DbSet<VwInventoryService> VwInventoryServices { get; set; }

    public virtual DbSet<VwInventoryServiceTran> VwInventoryServiceTrans { get; set; }

    public virtual DbSet<VwInventoryServiceTransList> VwInventoryServiceTransLists { get; set; }

    public virtual DbSet<VwInventorytran> VwInventorytrans { get; set; }

    public virtual DbSet<VwInventorytranslist> VwInventorytranslists { get; set; }

    public virtual DbSet<VwItemDvnnam> VwItemDvnnams { get; set; }

    public virtual DbSet<VwItemM> VwItemMs { get; set; }

    public virtual DbSet<VwItemRate> VwItemRates { get; set; }

    public virtual DbSet<VwItemRateHeader> VwItemRateHeaders { get; set; }

    public virtual DbSet<VwItemReOrderLevel> VwItemReOrderLevels { get; set; }

    public virtual DbSet<VwItemSeedM> VwItemSeedMs { get; set; }

    public virtual DbSet<VwItemhead> VwItemheads { get; set; }

    public virtual DbSet<VwItemheadDesc> VwItemheadDescs { get; set; }

    public virtual DbSet<VwItemmaster> VwItemmasters { get; set; }

    public virtual DbSet<VwItemmasterIsd> VwItemmasterIsds { get; set; }

    public virtual DbSet<VwItemsFallUnderScheme> VwItemsFallUnderSchemes { get; set; }

    public virtual DbSet<VwLiftDetailsForScheme> VwLiftDetailsForSchemes { get; set; }

    public virtual DbSet<VwOsStmt> VwOsStmts { get; set; }

    public virtual DbSet<VwParentBranch> VwParentBranches { get; set; }

    public virtual DbSet<VwPartyM> VwPartyMs { get; set; }

    public virtual DbSet<VwPaymentMadeDetailsForScheme> VwPaymentMadeDetailsForSchemes { get; set; }

    public virtual DbSet<VwPendingOrder> VwPendingOrders { get; set; }

    public virtual DbSet<VwPhysicalStockVerification> VwPhysicalStockVerifications { get; set; }

    public virtual DbSet<VwPodetail> VwPodetails { get; set; }

    public virtual DbSet<VwPoheader> VwPoheaders { get; set; }

    public virtual DbSet<VwPoindent> VwPoindents { get; set; }

    public virtual DbSet<VwPriceMapping> VwPriceMappings { get; set; }

    public virtual DbSet<VwProdLiftSal> VwProdLiftSals { get; set; }

    public virtual DbSet<VwProdSlip> VwProdSlips { get; set; }

    public virtual DbSet<VwProductwiseSalesSummary> VwProductwiseSalesSummaries { get; set; }

    public virtual DbSet<VwPurchaseConsignmentItem> VwPurchaseConsignmentItems { get; set; }

    public virtual DbSet<VwPurchaseInvoice> VwPurchaseInvoices { get; set; }

    public virtual DbSet<VwPurchaseInvoiceDetail> VwPurchaseInvoiceDetails { get; set; }

    public virtual DbSet<VwPurchaseInvoiceHeader> VwPurchaseInvoiceHeaders { get; set; }

    public virtual DbSet<VwPurchaseOrder> VwPurchaseOrders { get; set; }

    public virtual DbSet<VwPurchaseOrderAdvanceTotalAdjustmentAmt> VwPurchaseOrderAdvanceTotalAdjustmentAmts { get; set; }

    public virtual DbSet<VwRequestVoucher> VwRequestVouchers { get; set; }

    public virtual DbSet<VwRtFinal> VwRtFinals { get; set; }

    public virtual DbSet<VwSalesHead> VwSalesHeads { get; set; }

    public virtual DbSet<VwSalesList> VwSalesLists { get; set; }

    public virtual DbSet<VwSalesOfficerM> VwSalesOfficerMs { get; set; }

    public virtual DbSet<VwScheme> VwSchemes { get; set; }

    public virtual DbSet<VwSchemeAppliedFor> VwSchemeAppliedFors { get; set; }

    public virtual DbSet<VwSelectAreaSomappingForCurrentDate> VwSelectAreaSomappingForCurrentDates { get; set; }

    public virtual DbSet<VwSelectPurchaseInvoiceInventoryTransListUid> VwSelectPurchaseInvoiceInventoryTransListUids { get; set; }

    public virtual DbSet<VwSelectPurchaseInvoicePoheaderUid> VwSelectPurchaseInvoicePoheaderUids { get; set; }

    public virtual DbSet<VwSerinvFinal> VwSerinvFinals { get; set; }

    public virtual DbSet<VwServiceinvHead> VwServiceinvHeads { get; set; }

    public virtual DbSet<VwServiceinvList> VwServiceinvLists { get; set; }

    public virtual DbSet<VwSodetail> VwSodetails { get; set; }

    public virtual DbSet<VwSoforwardBranch> VwSoforwardBranches { get; set; }

    public virtual DbSet<VwSoheader> VwSoheaders { get; set; }

    public virtual DbSet<VwSoheaderHoapproved> VwSoheaderHoapproveds { get; set; }

    public virtual DbSet<VwStmtofac> VwStmtofacs { get; set; }

    public virtual DbSet<VwSupVoucherMatch> VwSupVoucherMatches { get; set; }

    public virtual DbSet<VwSupVoucherMatchCrTotalAdjustment> VwSupVoucherMatchCrTotalAdjustments { get; set; }

    public virtual DbSet<VwSupVoucherMatchCrTotalAdjustmentReport> VwSupVoucherMatchCrTotalAdjustmentReports { get; set; }

    public virtual DbSet<VwSupVoucherMatchDrTotalAdjustment> VwSupVoucherMatchDrTotalAdjustments { get; set; }

    public virtual DbSet<VwSupVoucherMatchDrTotalAdjustmentReport> VwSupVoucherMatchDrTotalAdjustmentReports { get; set; }

    public virtual DbSet<VwSupVoucherMatchInDetail> VwSupVoucherMatchInDetails { get; set; }

    public virtual DbSet<VwSupVoucherMatchReport> VwSupVoucherMatchReports { get; set; }

    public virtual DbSet<VwSupVoucherMatchWithPartyUid> VwSupVoucherMatchWithPartyUids { get; set; }

    public virtual DbSet<VwSupVoucherMatchWithPartyUidByStatus> VwSupVoucherMatchWithPartyUidByStatuses { get; set; }

    public virtual DbSet<VwTaxDetail> VwTaxDetails { get; set; }

    public virtual DbSet<VwTempVoucherMatchLink> VwTempVoucherMatchLinks { get; set; }

    public virtual DbSet<VwTestBranch> VwTestBranches { get; set; }

    public virtual DbSet<VwVoucher> VwVouchers { get; set; }

    public virtual DbSet<VwVoucherDetail> VwVoucherDetails { get; set; }

    public virtual DbSet<VwVoucherForBankDeposit> VwVoucherForBankDeposits { get; set; }

    public virtual DbSet<VwVoucherHeader> VwVoucherHeaders { get; set; }

    public virtual DbSet<VwVoucherMatch> VwVoucherMatches { get; set; }

    public virtual DbSet<VwVoucherMatchInDetail> VwVoucherMatchInDetails { get; set; }

    public virtual DbSet<VwVoucherMatchLink> VwVoucherMatchLinks { get; set; }

    public virtual DbSet<VwVoucherdoc> VwVoucherdocs { get; set; }

    public virtual DbSet<VwVoucr> VwVoucrs { get; set; }

    public virtual DbSet<VwVoudb> VwVoudbs { get; set; }

    public virtual DbSet<VwpaymentFinal> VwpaymentFinals { get; set; }

    public virtual DbSet<Vwvou> Vwvous { get; set; }

    public virtual DbSet<Vwvoup> Vwvoups { get; set; }

    public virtual DbSet<_159> _159s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BOSERVER_AWS;Database=S148_COIMBATORE_CIPD;User ID=ssis_user;Password=ssis+se;TrustServerCertificate=True;MultipleActiveResultSets=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountGroupM>(entity =>
        {
            entity.HasKey(e => e.AccountGroupUid)
                .HasName("PK_AccountMGroups")
                .HasFillFactor(90);

            entity.ToTable("AccountGroupM", tb =>
                {
                    tb.HasTrigger("TI_INSERT_AccountGroupM");
                    tb.HasTrigger("TR_IsGroupUpdation");
                });

            entity.HasIndex(e => e.AccountUid, "IX_AccountUID").HasFillFactor(90);

            entity.HasIndex(e => new { e.AccountUid, e.UnderAccountUid }, "IX_AccountUID_UnderAccontUID").HasFillFactor(90);

            entity.HasIndex(e => e.UnderAccountUid, "IX_UnderAccountUID").HasFillFactor(90);

            entity.HasIndex(e => new { e.UnderAccountUid, e.AccountUid }, "IX_UnderAccountUID_AccountUID").HasFillFactor(90);

            entity.Property(e => e.AccountGroupUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.UnderAccountU).WithMany(p => p.AccountGroupMs).HasConstraintName("FK_AccountMGroups_AccountM");
        });

        modelBuilder.Entity<AccountM>(entity =>
        {
            entity.HasKey(e => e.AccountUid).HasFillFactor(90);

            entity.ToTable("AccountM", tb => tb.HasTrigger("ProtectDataAccountM"));

            entity.HasIndex(e => e.AccountCode, "IX_AccountCode").HasFillFactor(90);

            entity.HasIndex(e => new { e.AccountCode, e.AccountDescription }, "IX_AccountCode_AccountDescription").HasFillFactor(90);

            entity.HasIndex(e => e.AccountDescription, "IX_AccountDescription").HasFillFactor(90);

            entity.HasIndex(e => new { e.AccountDescription, e.AccountCode }, "IX_AccountDescription_AccountCode").HasFillFactor(90);

            entity.HasIndex(e => new { e.AccountCode, e.AccountDescription, e.IsActive }, "IX_AccountM").HasFillFactor(90);

            entity.HasIndex(e => e.AccountCode, "UK_AccountM")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.AccountUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsBranch)
                .HasDefaultValue("N")
                .IsFixedLength();
            entity.Property(e => e.IsDivision).HasDefaultValue(false);
        });

        modelBuilder.Entity<ActualStatusM>(entity =>
        {
            entity.HasKey(e => e.ActualStatusUid).HasFillFactor(30);

            entity.Property(e => e.ActualStatusUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<AffectedAccountTypesM>(entity =>
        {
            entity.HasKey(e => e.AffectedAccountTypesUid).HasFillFactor(80);

            entity.Property(e => e.AffectedAccountTypesUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Announcement>(entity =>
        {
            entity.HasKey(e => e.AnnouncementUid).HasFillFactor(80);

            entity.Property(e => e.AnnouncementUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ApprovedVoucherDetail>(entity =>
        {
            entity.HasKey(e => e.ApprovedVoucherDetailUid).HasFillFactor(90);

            entity.Property(e => e.ApprovedVoucherDetailUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ApprovedVoucherDetailExtn>(entity =>
        {
            entity.HasKey(e => e.ApprovedVoucherDetailUid).HasFillFactor(90);

            entity.Property(e => e.ApprovedVoucherDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ApprovedVoucherHeader>(entity =>
        {
            entity.HasKey(e => e.ApprovedVoucherHeaderUid).HasFillFactor(90);

            entity.Property(e => e.ApprovedVoucherHeaderUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ApprovedVoucherHeaderExtn>(entity =>
        {
            entity.HasKey(e => e.ApprovedVoucherHeaderUid).HasFillFactor(90);

            entity.Property(e => e.ApprovedVoucherHeaderUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<AreaItemRate>(entity =>
        {
            entity.HasKey(e => e.AreaItemRateUid).HasFillFactor(90);

            entity.ToTable("AreaItemRate", tb => tb.HasTrigger("TI_DeletedAreaItemRate"));

            entity.Property(e => e.AreaItemRateUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemRateHeaderU).WithMany(p => p.AreaItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaItemRate_ItemRateHeader");
        });

        modelBuilder.Entity<AreaM>(entity =>
        {
            entity.HasKey(e => e.AreaUid).HasFillFactor(90);

            entity.ToTable("AreaM", tb => tb.HasTrigger("TI_AreaCodeSlno"));

            entity.Property(e => e.AreaUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BranchU).WithMany(p => p.AreaMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaM_BranchM");
        });

        modelBuilder.Entity<AreaSoitemGroup>(entity =>
        {
            entity.HasKey(e => e.AreaSoitemGroupUid).HasFillFactor(90);

            entity.Property(e => e.AreaSoitemGroupUid).ValueGeneratedNever();
            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AreaSou).WithMany(p => p.AreaSoitemGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaSOItemGroup_AreaSOMapping");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.AreaSoitemGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaSOItemGroup_DivisionPrincipleM");
        });

        modelBuilder.Entity<AreaSomapping>(entity =>
        {
            entity.HasKey(e => e.AreaSouid).HasFillFactor(90);

            entity.Property(e => e.AreaSouid).ValueGeneratedNever();

            entity.HasOne(d => d.Sou).WithMany(p => p.AreaSomappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaSOMapping_SalesOfficerM");
        });

        modelBuilder.Entity<BankM>(entity =>
        {
            entity.HasKey(e => e.BankUid).HasFillFactor(90);

            entity.Property(e => e.BankUid).ValueGeneratedNever();
            entity.Property(e => e.AccountNo).HasDefaultValue("");
        });

        modelBuilder.Entity<BatchDetail>(entity =>
        {
            entity.ToView("BatchDetails");
        });

        modelBuilder.Entity<BatchSlNo>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_BatchSlNos"));
        });

        modelBuilder.Entity<BceReimb>(entity =>
        {
            entity.HasKey(e => e.BceReimbUid).HasFillFactor(90);

            entity.ToTable("BceReimb", tb => tb.HasTrigger("TI_Validate_BceReimb_ReqStatementNo"));

            entity.Property(e => e.BceReimbUid).ValueGeneratedNever();
            entity.Property(e => e.Type).IsFixedLength();
        });

        modelBuilder.Entity<BceaccountCheck>(entity =>
        {
            entity.ToView("BCEAccountCheck");
        });

        modelBuilder.Entity<BceaccountDetail>(entity =>
        {
            entity.HasKey(e => e.BceaccountDetailsUid)
                .HasName("PK_BCEOpBal")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.BranchUid, e.DivisionUid }, "UQ_DivisionUID_BranchUID")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BceaccountDetailsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BcedenominationDetail>(entity =>
        {
            entity.Property(e => e.BceDenominationUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BcerequestLevelPercentage>(entity =>
        {
            entity.HasKey(e => e.BcerequestLevelPerUid).HasFillFactor(30);

            entity.Property(e => e.BcerequestLevelPerUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Bcettccheck>(entity =>
        {
            entity.ToView("BCETTCCheck");
        });

        modelBuilder.Entity<Bdstatus>(entity =>
        {
            entity.HasKey(e => e.BdstatusUid).HasFillFactor(30);

            entity.ToTable("BDStatus", tb => tb.HasTrigger("InsertIntoBDColledted"));

            entity.Property(e => e.BdstatusUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BillPassing>(entity =>
        {
            entity.HasKey(e => e.BillPassingUid).HasFillFactor(80);

            entity.Property(e => e.BillPassingUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BrMasSt>(entity =>
        {
            entity.ToView("Br_mas_st");
        });

        modelBuilder.Entity<BrMgrBankDebitDetail>(entity =>
        {
            entity.HasKey(e => e.BrMgrBankDebitDetailUid)
                .HasName("PK__BrMgrBan__8DEB2F5C2E1E3E47")
                .HasFillFactor(90);

            entity.Property(e => e.BrMgrBankDebitDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BranchCreditNoteRegularApproval>(entity =>
        {
            entity.HasKey(e => e.BrCrNoteRegApprovalUid).HasFillFactor(90);

            entity.Property(e => e.BrCrNoteRegApprovalUid).ValueGeneratedNever();

            entity.HasOne(d => d.AccountU).WithMany(p => p.BranchCreditNoteRegularApprovals).HasConstraintName("FK_BranchCreditNoteRegularApproval_AccountM");

            entity.HasOne(d => d.BranchU).WithMany(p => p.BranchCreditNoteRegularApprovals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchCreditNoteRegularApproval_BranchM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.BranchCreditNoteRegularApprovals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchCreditNoteRegularApproval_DivisionM");

            entity.HasOne(d => d.PurposeU).WithMany(p => p.BranchCreditNoteRegularApprovals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchCreditNoteRegularApproval_TransactionTypePurposeDetailM");
        });

        modelBuilder.Entity<BranchCreditNoteRegularApproved>(entity =>
        {
            entity.HasKey(e => e.BrCrNoteRegApprovalUid).HasFillFactor(90);

            entity.ToTable("BranchCreditNoteRegularApproved", tb => tb.HasTrigger("Tr_ValidateApprovalNo"));

            entity.Property(e => e.BrCrNoteRegApprovalUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BranchCreditNoteRegularRejected>(entity =>
        {
            entity.HasKey(e => e.BrCrNoteRegApprovalUid).HasFillFactor(30);

            entity.Property(e => e.BrCrNoteRegApprovalUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BranchCreditNoteRegularRequest>(entity =>
        {
            entity.HasKey(e => e.BrCrNoteRegRequestUid).HasFillFactor(80);

            entity.Property(e => e.BrCrNoteRegRequestUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.BranchCreditNoteRegularRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchCreditNoteRegularRequest_BranchM");

            entity.HasOne(d => d.CreditAccountU).WithMany(p => p.BranchCreditNoteRegularRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchCreditNoteRegularRequest_AccountM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.BranchCreditNoteRegularRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchCreditNoteRegularRequest_DivisionM");

            entity.HasOne(d => d.PurposeU).WithMany(p => p.BranchCreditNoteRegularRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchCreditNoteRegularRequest_TransactionTypePurposeDetailM");
        });

        modelBuilder.Entity<BranchDivisionLink>(entity =>
        {
            entity.HasKey(e => e.BranchDivisionLinkUid).HasFillFactor(90);

            entity.ToTable("BranchDivisionLink", tb => tb.HasTrigger("UpdateSundryCreditorDebtorCode"));

            entity.Property(e => e.BranchDivisionLinkUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BranchU).WithMany(p => p.BranchDivisionLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchDivisionLink_BranchM");

            entity.HasOne(d => d.DealerDepositU).WithMany(p => p.BranchDivisionLinkDealerDepositUs).HasConstraintName("FK_BranchDivisionLink_BranchDivisionLink_DealerDepositUID");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.BranchDivisionLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchDivisionLink_DivisionM");

            entity.HasOne(d => d.ImprestCodeU).WithMany(p => p.BranchDivisionLinkImprestCodeUs).HasConstraintName("FK_BranchDivisionLink_BranchDivisionLink_ImprestCodeUID");

            entity.HasOne(d => d.PostageImprestU).WithMany(p => p.BranchDivisionLinkPostageImprestUs).HasConstraintName("FK_BranchDivisionLink_BranchDivisionLink_PostageImprestUID");

            entity.HasOne(d => d.SosimprestU).WithMany(p => p.BranchDivisionLinkSosimprestUs).HasConstraintName("FK_BranchDivisionLink_BranchDivisionLink_SOSImprestUID");

            entity.HasOne(d => d.SpecialImprestCodeU).WithMany(p => p.BranchDivisionLinkSpecialImprestCodeUs).HasConstraintName("FK_BranchDivisionLink_BranchDivisionLink_SpecialImprestCodeUID");
        });

        modelBuilder.Entity<BranchImprest>(entity =>
        {
            entity.HasKey(e => e.BranchImprestAmountUid).HasFillFactor(90);

            entity.HasIndex(e => new { e.BranchUid, e.DivisionUid, e.AccountUid }, "UQ_BranchUID_DivisionUID_AccountUID")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BranchImprestAmountUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.BranchImprests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchImprest_BranchM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.BranchImprests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchImprest_DivisionM");
        });

        modelBuilder.Entity<BranchItemRate>(entity =>
        {
            entity.HasKey(e => e.BranchItemRateUid).HasFillFactor(90);

            entity.ToTable("BranchItemRate", tb => tb.HasTrigger("TI_DeletedBranchItemRate"));

            entity.Property(e => e.BranchItemRateUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.BranchItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchItemRate_BranchM");

            entity.HasOne(d => d.ItemRateHeaderU).WithMany(p => p.BranchItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchItemRate_ItemRateHeader");
        });

        modelBuilder.Entity<BranchLookup>(entity =>
        {
            entity.ToView("BRANCH_LOOKUP");
        });

        modelBuilder.Entity<BranchM>(entity =>
        {
            entity.HasKey(e => e.BranchUid).HasFillFactor(90);

            entity.HasIndex(e => e.BranchCode, "IX_BranchCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<BranchPoreceived>(entity =>
        {
            entity.HasKey(e => e.BranchPoreceivedUid).HasFillFactor(90);

            entity.Property(e => e.BranchPoreceivedUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BranchPotoReceive>(entity =>
        {
            entity.HasKey(e => e.BranchPoreceiptUid).HasFillFactor(90);

            entity.Property(e => e.BranchPoreceiptUid).ValueGeneratedNever();
            entity.Property(e => e.AmendMinusQty).HasDefaultValueSql("(NULL)");
        });

        modelBuilder.Entity<BranchTransferReceipt>(entity =>
        {
            entity.HasKey(e => e.BranchTransferReceiptGuid).HasFillFactor(90);

            entity.Property(e => e.BranchTransferReceiptGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<BranchTransferReceiptFromBranch>(entity =>
        {
            entity.HasKey(e => e.BranchTransferReceiptFromBranchGuid).HasFillFactor(90);

            entity.Property(e => e.BranchTransferReceiptFromBranchGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<BudgetM>(entity =>
        {
            entity.ToTable("BudgetM", tb => tb.HasTrigger("trg_AfterInsertUpdate_BudgetM"));

            entity.Property(e => e.BudgetUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<CalenderYearM>(entity =>
        {
            entity.Property(e => e.CalenderYearUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<CardSalesServiceInvoice>(entity =>
        {
            entity.HasKey(e => e.CardSalesServiceInvoiceUid)
                .HasName("FK_CardSalesServiceInvoice")
                .HasFillFactor(30);

            entity.Property(e => e.CardSalesServiceInvoiceUid).ValueGeneratedNever();

            entity.HasOne(d => d.InventoryTransU).WithMany(p => p.CardSalesServiceInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CardSalesServiceInvoice_InventoryTrans");
        });

        modelBuilder.Entity<CashFlowGroupM>(entity =>
        {
            entity.HasKey(e => e.CashFlowGroupUid).HasFillFactor(80);

            entity.Property(e => e.CashFlowGroupUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChemicalM>(entity =>
        {
            entity.HasKey(e => e.ChemicalUid).HasFillFactor(80);

            entity.HasIndex(e => e.ChemicalCode, "IX_ChemicalCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ChemicalUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ChequeBounceDetail1>(entity =>
        {
            entity.ToView("ChequeBounceDetails");
        });

        modelBuilder.Entity<ChequeBounceHistory>(entity =>
        {
            entity.HasKey(e => e.ChequeBounceHistoryUid).HasFillFactor(90);

            entity.Property(e => e.ChequeBounceHistoryUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ChequeLodgementDetail>(entity =>
        {
            entity.HasKey(e => e.ChequeLodgementDetailUid).HasFillFactor(80);

            entity.Property(e => e.ChequeLodgementDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChequeLodgementDetail1>(entity =>
        {
            entity.ToView("ChequeLodgementDetails");
        });

        modelBuilder.Entity<ChequebounceDetail>(entity =>
        {
            entity.HasKey(e => e.ChequeBounceDetailUid).HasFillFactor(30);

            entity.Property(e => e.ChequeBounceDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<CommodityCodeM>(entity =>
        {
            entity.HasKey(e => e.CommodityUid).HasFillFactor(80);

            entity.Property(e => e.CommodityUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CompanyM>(entity =>
        {
            entity.HasKey(e => e.CompanyUid).HasFillFactor(80);

            entity.Property(e => e.CompanyUid).ValueGeneratedNever();
            entity.Property(e => e.CompanyCode).IsFixedLength();
        });

        modelBuilder.Entity<ConsignmentDetail>(entity =>
        {
            entity.HasKey(e => e.ConsignmentLineUid).HasFillFactor(90);

            entity.ToTable("ConsignmentDetail", tb =>
                {
                    tb.HasTrigger("InsertConsignmentDetailToBranchPOToReceive");
                    tb.HasTrigger("TI_ConsignmentLineUID");
                });

            entity.Property(e => e.AmendMinusQty).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.ConsignmentHeaderU).WithMany(p => p.ConsignmentDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsignmentDetail_ConsignmentHeader");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ConsignmentDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsignmentDetail_ItemM");
        });

        modelBuilder.Entity<ConsignmentHeader>(entity =>
        {
            entity.HasKey(e => e.ConsignmentHeaderUid).HasFillFactor(90);

            entity.ToTable("ConsignmentHeader", tb =>
                {
                    tb.HasTrigger("TI_ConsignmentHeaderDocumentNo");
                    tb.HasTrigger("TI_ConsignmentHeaderUID");
                    tb.HasTrigger("TI_Validate_ConsignmentHeader_ConsignmentNo");
                    tb.HasTrigger("TI_Validate_ConsignmentHeader_RefNo");
                });

            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.ConsignmentHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsignmentHeader_DivisionM");

            entity.HasOne(d => d.RequestedBranchU).WithMany(p => p.ConsignmentHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsignmentHeader_BranchM");

            entity.HasOne(d => d.SupplierU).WithMany(p => p.ConsignmentHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsignmentHeader_PartyM");
        });

        modelBuilder.Entity<ConsolidatedMonthlyClosingstock>(entity =>
        {
            entity.HasKey(e => e.Cmcsuid).HasFillFactor(80);

            entity.Property(e => e.Cmcsuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ConsolidatedMonthlySalesBook>(entity =>
        {
            entity.HasKey(e => e.CmsbookUid).HasFillFactor(80);

            entity.Property(e => e.CmsbookUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorFunctionMaster>(entity =>
        {
            entity.HasKey(e => e.FunctionUid).HasName("PK_ContOperationMaster");

            entity.Property(e => e.FunctionUid).ValueGeneratedNever();
            entity.Property(e => e.ConvFact).IsFixedLength();
        });

        modelBuilder.Entity<ContractorGstaccountDetail>(entity =>
        {
            entity.Property(e => e.ContractorGstaccountDetailsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorRateMaster>(entity =>
        {
            entity.Property(e => e.ContractorRateUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorTranAppDetail>(entity =>
        {
            entity.HasKey(e => e.ContPayAppDetailUid).HasName("PK_ContPayAppDetail");

            entity.Property(e => e.ContPayAppDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorTranAppHeader>(entity =>
        {
            entity.HasKey(e => e.ContPayAppHeaderUid).HasName("PK_ContPayAppHeader");

            entity.Property(e => e.ContPayAppHeaderUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorTranFnLink>(entity =>
        {
            entity.Property(e => e.ContractorTranFnLinkUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorTranReqDetail>(entity =>
        {
            entity.HasKey(e => e.ContPayReqDetailUid).HasName("PK_ContPayReqDetail");

            entity.Property(e => e.ContPayReqDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorTranReqHeader>(entity =>
        {
            entity.HasKey(e => e.ContPayReqHeaderUid).HasName("PK_ContPayReqHeader");

            entity.Property(e => e.ContPayReqHeaderUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractorTranSubDetail>(entity =>
        {
            entity.HasOne(d => d.ContPayReqDetailU).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractorTranSubDetail_ContractorTranReqDetail");
        });

        modelBuilder.Entity<CosaepostingStatus>(entity =>
        {
            entity.HasKey(e => e.CosaestatusUid).HasFillFactor(30);

            entity.Property(e => e.CosaestatusUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<CountryItemRate>(entity =>
        {
            entity.HasKey(e => e.CountryItemRateUid).HasFillFactor(80);

            entity.ToTable("CountryItemRate", tb => tb.HasTrigger("TI_DeletedCountryItemRate"));

            entity.Property(e => e.CountryItemRateUid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryU).WithMany(p => p.CountryItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountryItemRate_CountryM");

            entity.HasOne(d => d.ItemRateHeaderU).WithMany(p => p.CountryItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CountryItemRate_ItemRateHeader");
        });

        modelBuilder.Entity<CountryM>(entity =>
        {
            entity.HasKey(e => e.CountryUid).HasFillFactor(90);

            entity.Property(e => e.CountryUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<CrDrNoteInvoiceLink>(entity =>
        {
            entity.HasKey(e => e.CrDrNoteInvoiceLinkUid)
                .HasName("PK_CreditNoteInvoiceLink")
                .HasFillFactor(80);

            entity.Property(e => e.CrDrNoteInvoiceLinkUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<CreditDaysM>(entity =>
        {
            entity.HasKey(e => e.CreditDaysMuid).HasFillFactor(80);

            entity.HasIndex(e => new { e.DivisionUid, e.DivisionPrincipleUid }, "UK_CreditDaysM").HasFillFactor(80);

            entity.Property(e => e.CreditDaysMuid).ValueGeneratedNever();

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.CreditDaysMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditDaysM_DivisionPrincipleM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.CreditDaysMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditDaysM_DivisionM");
        });

        modelBuilder.Entity<CurrencyExChangeDetail>(entity =>
        {
            entity.HasKey(e => e.CurrencyExChangeUid).HasFillFactor(80);

            entity.Property(e => e.CurrencyExChangeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<CurrencyM>(entity =>
        {
            entity.HasKey(e => e.CurrencyUid).HasFillFactor(80);

            entity.Property(e => e.CurrencyUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<DealerAsset>(entity =>
        {
            entity.HasKey(e => e.DealerAssetUid)
                .HasName("PK_DealerAssetRequest")
                .HasFillFactor(90);

            entity.ToTable("DealerAsset", tb => tb.HasTrigger("RequestDealerAsset_Tr"));

            entity.Property(e => e.DealerAssetUid).ValueGeneratedNever();

            entity.HasOne(d => d.PartyU).WithMany(p => p.DealerAssets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealerAssetRequest_PartyRequest");
        });

        modelBuilder.Entity<DealerBankDetail>(entity =>
        {
            entity.HasKey(e => e.DealerBankDetailsUid).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("RequestDealerBankDetails_Tr"));

            entity.Property(e => e.DealerBankDetailsUid).ValueGeneratedNever();

            entity.HasOne(d => d.PartyU).WithMany(p => p.DealerBankDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealerBankDetails_PartyM");
        });

        modelBuilder.Entity<DealerCategoryItemRate>(entity =>
        {
            entity.HasKey(e => e.DealerCategoryItemRateUid).HasFillFactor(90);

            entity.ToTable("DealerCategoryItemRate", tb => tb.HasTrigger("TI_DeletedDealerCategoryItemRate"));

            entity.Property(e => e.DealerCategoryItemRateUid).ValueGeneratedNever();

            entity.HasOne(d => d.DealerCategoryU).WithMany(p => p.DealerCategoryItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealerCategoryItemRate_DealerCategoryM");

            entity.HasOne(d => d.ItemRateHeaderU).WithMany(p => p.DealerCategoryItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealerCategoryItemRate_ItemRateHeader");
        });

        modelBuilder.Entity<DealerCategoryM>(entity =>
        {
            entity.HasKey(e => e.DealerCategoryUid).HasFillFactor(80);

            entity.HasIndex(e => e.DealerCategoryCode, "IX_DealerCategoryCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.DealerCategoryUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<DealerDeposit>(entity =>
        {
            entity.HasKey(e => e.DealerDepositUid)
                .HasName("PK_DealerDepositRequest")
                .HasFillFactor(90);

            entity.ToTable("DealerDeposit", tb => tb.HasTrigger("RequestDealerDeposit_Tr"));

            entity.Property(e => e.DealerDepositUid).ValueGeneratedNever();
            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.DealerDeposits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealerDeposit_DivisionPrincipleM");

            entity.HasOne(d => d.PartyU).WithMany(p => p.DealerDeposits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealerDepositRequest_PartyRequest");
        });

        modelBuilder.Entity<DealerItemRate>(entity =>
        {
            entity.HasKey(e => e.DealerItemRateUid).HasFillFactor(90);

            entity.ToTable("DealerItemRate", tb => tb.HasTrigger("TI_DeletedDealerItemRate"));

            entity.Property(e => e.DealerItemRateUid).ValueGeneratedNever();

            entity.HasOne(d => d.PartyU).WithMany(p => p.DealerItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DealerItemRate_PartyM");
        });

        modelBuilder.Entity<DepartmentM>(entity =>
        {
            entity.HasKey(e => e.DepartmentUid).HasFillFactor(80);

            entity.Property(e => e.DepartmentUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<DepartmentalDivisionM>(entity =>
        {
            entity.HasKey(e => e.DepartmentalDivisionUid).HasFillFactor(80);

            entity.Property(e => e.DepartmentalDivisionUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DepositDetail>(entity =>
        {
            entity.HasKey(e => e.DepositDetailUid).HasFillFactor(30);

            entity.Property(e => e.DepositDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DiccashCreditProfile>(entity =>
        {
            entity.Property(e => e.DiccashCreditProfileUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Dicfertiliter>(entity =>
        {
            entity.Property(e => e.DicfertilitersUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Dicmaster>(entity =>
        {
            entity.Property(e => e.Dicuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DicotherAgriInput>(entity =>
        {
            entity.Property(e => e.DicothersAgriInputsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DicpartnershipDetail>(entity =>
        {
            entity.Property(e => e.PartnershipUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Dicpesticide>(entity =>
        {
            entity.Property(e => e.DicpesticidesUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Dicseed>(entity =>
        {
            entity.Property(e => e.DicseedsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DictopBiological>(entity =>
        {
            entity.Property(e => e.DictopBiologicalsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DictopCompaniesDetail>(entity =>
        {
            entity.Property(e => e.DictopCompaniesUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DictopCrop>(entity =>
        {
            entity.Property(e => e.DictopCropsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DictopFormulation>(entity =>
        {
            entity.Property(e => e.DictopFormulationsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DictopMolecule>(entity =>
        {
            entity.Property(e => e.DictopMoleculesUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DictopProgresiveVillagesFarmer>(entity =>
        {
            entity.Property(e => e.DictopProgresiveVillagesFarmersUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Discount4ControlM>(entity =>
        {
            entity.HasKey(e => e.Discount4ControlMuid).HasFillFactor(80);

            entity.Property(e => e.Discount4ControlMuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DiscountItemLink>(entity =>
        {
            entity.HasKey(e => e.DiscountItemLinkUid).HasFillFactor(90);

            entity.Property(e => e.DiscountItemLinkUid).ValueGeneratedNever();

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountItemLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountItemLink_DiscountM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.DiscountItemLinks).HasConstraintName("FK_DiscountItemLink_DivisionM");

            entity.HasOne(d => d.ItemGroupU).WithMany(p => p.DiscountItemLinks).HasConstraintName("FK_DiscountItemLink_ItemGroupM");

            entity.HasOne(d => d.ItemSubGroupU).WithMany(p => p.DiscountItemLinks).HasConstraintName("FK_DiscountItemLink_ItemSubGroupM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.DiscountItemLinks).HasConstraintName("FK_DiscountItemLink_ItemM");
        });

        modelBuilder.Entity<DiscountM>(entity =>
        {
            entity.HasKey(e => e.DiscountUid).HasFillFactor(90);

            entity.ToTable("DiscountM", tb =>
                {
                    tb.HasTrigger("CheckDiscountAlreadyExist");
                    tb.HasTrigger("Trg_IsProcessedDiscountM");
                });

            entity.HasIndex(e => e.DiscountDesc, "UQ_DiscountDesc")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.DiscountUid).ValueGeneratedNever();
            entity.Property(e => e.PrintDescription).HasDefaultValue("");

            entity.HasOne(d => d.DiscountTypeU).WithMany(p => p.DiscountMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountM_DiscountTypeM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.DiscountMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountM_DivisionM1");
        });

        modelBuilder.Entity<DiscountMappingArea>(entity =>
        {
            entity.HasKey(e => e.DiscountMappingAreaUid).HasFillFactor(90);

            entity.Property(e => e.DiscountMappingAreaUid).ValueGeneratedNever();
            entity.Property(e => e.AreaUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountMappingAreas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingArea_DiscountM");
        });

        modelBuilder.Entity<DiscountMappingBranch>(entity =>
        {
            entity.HasKey(e => e.DiscountMappingBranchUid).HasFillFactor(90);

            entity.Property(e => e.DiscountMappingBranchUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BranchU).WithMany(p => p.DiscountMappingBranches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingBranch_BranchM");

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountMappingBranches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingBranch_DiscountM");
        });

        modelBuilder.Entity<DiscountMappingCountry>(entity =>
        {
            entity.HasKey(e => e.DiscountMappingCountryUid).HasFillFactor(80);

            entity.Property(e => e.DiscountMappingCountryUid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryU).WithMany(p => p.DiscountMappingCountries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingCountry_CountryM");

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountMappingCountries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingCountry_DiscountM");
        });

        modelBuilder.Entity<DiscountMappingDealer>(entity =>
        {
            entity.HasKey(e => e.DiscountMappingDealerUid).HasFillFactor(90);

            entity.Property(e => e.DiscountMappingDealerUid).ValueGeneratedNever();

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountMappingDealers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingDealer_DiscountM");

            entity.HasOne(d => d.PartyU).WithMany(p => p.DiscountMappingDealers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingDealer_PartyM");
        });

        modelBuilder.Entity<DiscountMappingDealerCategory>(entity =>
        {
            entity.HasKey(e => e.DiscountMappingDealerCategoryUid).HasFillFactor(80);

            entity.Property(e => e.DiscountMappingDealerCategoryUid).ValueGeneratedNever();
            entity.Property(e => e.DealerCategoryUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DealerCategoryU).WithMany(p => p.DiscountMappingDealerCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingDealerCategory_DealerCategoryM");

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountMappingDealerCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingDealerCategory_DiscountM");
        });

        modelBuilder.Entity<DiscountMappingState>(entity =>
        {
            entity.HasKey(e => e.DiscountMappingStateUid).HasFillFactor(90);

            entity.Property(e => e.DiscountMappingStateUid).ValueGeneratedNever();

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountMappingStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingState_DiscountM");

            entity.HasOne(d => d.StateU).WithMany(p => p.DiscountMappingStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountMappingState_StateM");
        });

        modelBuilder.Entity<DiscountPaymentMade>(entity =>
        {
            entity.HasKey(e => e.DiscountPaymentMadeUid).HasFillFactor(80);

            entity.Property(e => e.DiscountPaymentMadeUid).ValueGeneratedNever();

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountPaymentMades)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPaymentMade_DiscountM");
        });

        modelBuilder.Entity<DiscountPercentageallowed>(entity =>
        {
            entity.HasKey(e => e.DiscountPercentageallowedUid).HasFillFactor(90);

            entity.Property(e => e.DiscountPercentageallowedUid).ValueGeneratedNever();

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.DiscountPercentagealloweds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPercentageallowed_DivisionPrincipleM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.DiscountPercentagealloweds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountPercentageallowed_DivisionM");
        });

        modelBuilder.Entity<DiscountQtyLift>(entity =>
        {
            entity.HasKey(e => e.DiscountQtyLiftUid)
                .HasName("PK_DiscountQtyLift_1")
                .HasFillFactor(90);

            entity.Property(e => e.DiscountQtyLiftUid).ValueGeneratedNever();

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountQtyLifts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountQtyLift_DiscountM1");
        });

        modelBuilder.Entity<DiscountTypeM>(entity =>
        {
            entity.HasKey(e => e.DiscountTypeUid).HasFillFactor(80);

            entity.Property(e => e.DiscountTypeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DiscountValueLift>(entity =>
        {
            entity.HasKey(e => e.DiscountValueLiftUid).HasFillFactor(90);

            entity.Property(e => e.DiscountValueLiftUid).ValueGeneratedNever();

            entity.HasOne(d => d.DiscountU).WithMany(p => p.DiscountValueLifts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountValueLift_DiscountM");
        });

        modelBuilder.Entity<DistanceChart>(entity =>
        {
            entity.HasKey(e => e.DistanceChartUid).HasFillFactor(80);

            entity.Property(e => e.DistanceChartUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DivisionGroupM>(entity =>
        {
            entity.HasKey(e => e.DivisionGroupMuid).HasFillFactor(80);

            entity.Property(e => e.DivisionGroupMuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DivisionM>(entity =>
        {
            entity.HasKey(e => e.DivisionUid).HasFillFactor(80);

            entity.HasIndex(e => e.DivisionCode, "IX_DivisionCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<DivisionPrincipleM>(entity =>
        {
            entity.HasKey(e => e.DivisionPrincipleUid).HasFillFactor(80);

            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.PrincipleCode)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength();

            entity.HasOne(d => d.DivsionU).WithMany(p => p.DivisionPrincipleMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DivisionPrincipleM_DivisionM");
        });

        modelBuilder.Entity<DocumentSlNo>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_DocumentSlNos"));
        });

        modelBuilder.Entity<DocumentSlNosAccountPosting>(entity =>
        {
            entity.ToTable("DocumentSlNos_AccountPosting", tb => tb.HasTrigger("TR_DocumentSlNos_AccountPosting"));
        });

        modelBuilder.Entity<DocumentSlNosSale>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_DocumentSlNosSales"));
        });

        modelBuilder.Entity<DocumentSlNosStockTransfer>(entity =>
        {
            entity.ToTable("DocumentSlNos_StockTransfer", tb => tb.HasTrigger("TR_DocumentSlNos_StockTransfer"));
        });

        modelBuilder.Entity<DrCrCodeSelect>(entity =>
        {
            entity.HasKey(e => e.DrCrCodeSelectUid).HasFillFactor(80);

            entity.Property(e => e.DrCrCodeSelectUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TransactionTypePurposeTranUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BranchU).WithMany(p => p.DrCrCodeSelects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrCrCodeSelect_BranchM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.DrCrCodeSelects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrCrCodeSelect_DivisionM");

            entity.HasOne(d => d.TransactionTypePurposeTranU).WithMany(p => p.DrCrCodeSelects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrCrCodeSelect_TransactionTypePurposeDetailM");

            entity.HasOne(d => d.TransactionTypesU).WithMany(p => p.DrCrCodeSelects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DrCrCodeSelect_TransactionTypesM");
        });

        modelBuilder.Entity<DrcrcodeSelectLink>(entity =>
        {
            entity.HasKey(e => e.DrcrcodeSelectLinkUid).HasFillFactor(80);

            entity.Property(e => e.DrcrcodeSelectLinkUid).ValueGeneratedNever();

            entity.HasOne(d => d.DrCrCodeSelectU).WithMany(p => p.DrcrcodeSelectLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DRCRCodeSelectLink_DrCrCodeSelect");
        });

        modelBuilder.Entity<DrcrnoteHoapproved>(entity =>
        {
            entity.HasKey(e => e.DrcrnoteHoapprovedUid).HasFillFactor(90);

            entity.Property(e => e.DrcrnoteHoapprovedUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<DrcrnoteHotoApprove>(entity =>
        {
            entity.HasKey(e => e.DrcrnoteHotoApproveUid)
                .HasName("PK_CRDRNoteHOtoApprove")
                .HasFillFactor(80);

            entity.Property(e => e.DrcrnoteHotoApproveUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EdCharge>(entity =>
        {
            entity.ToView("ED_CHARGES");
        });

        modelBuilder.Entity<EdchargesM>(entity =>
        {
            entity.HasKey(e => e.EdChargesUid).HasFillFactor(30);

            entity.Property(e => e.EdChargesUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.EdchargesMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRanchM_EDChargesM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.EdchargesMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemM_EDChargesM");
        });

        modelBuilder.Entity<Edmaster>(entity =>
        {
            entity.HasKey(e => e.EdmasterUid).HasFillFactor(80);

            entity.Property(e => e.EdmasterUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemU).WithMany(p => p.Edmasters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EDMaster_ItemUID");
        });

        modelBuilder.Entity<Edsissue>(entity =>
        {
            entity.HasIndex(e => e.ItemCode, "IX_EDSIssues1").HasFillFactor(80);

            entity.HasIndex(e => e.Date, "IX_EDSIssues2").HasFillFactor(80);

            entity.Property(e => e.Batch).IsFixedLength();
            entity.Property(e => e.Status).IsFixedLength();
        });

        modelBuilder.Entity<EdsqtyCalculationTable>(entity =>
        {
            entity.HasIndex(e => new { e.Itemcode, e.BranchCode }, "IX_EDSQtyCalculationTable1").HasFillFactor(80);
        });

        modelBuilder.Entity<Edsreceipt>(entity =>
        {
            entity.HasIndex(e => new { e.ItemCode, e.TransType, e.Status }, "IX_EDSReceipts1").HasFillFactor(80);

            entity.HasIndex(e => new { e.ItemCode, e.TransType, e.Status, e.Level }, "IX_EDSReceipts2").HasFillFactor(80);

            entity.HasIndex(e => e.Date, "IX_EDSReceipts3").HasFillFactor(80);

            entity.HasIndex(e => new { e.BranchCode, e.HeaderId, e.RowId, e.ItemCode }, "IX_EDSReceipts4").HasFillFactor(80);

            entity.HasIndex(e => new { e.BranchCode, e.ItemCode, e.Date }, "IX_EDSReceipts5").HasFillFactor(80);

            entity.HasIndex(e => new { e.Status, e.BranchCode, e.ItemCode, e.Rate, e.Level, e.Date }, "IX_EDSReceipts6").HasFillFactor(80);

            entity.HasIndex(e => new { e.TransType, e.BranchCode, e.ItemCode, e.Rate, e.Level, e.Date }, "IX_EDSReceipts7").HasFillFactor(80);

            entity.HasIndex(e => new { e.ItemCode, e.BranchCode }, "IX_EDSReceipts8").HasFillFactor(80);

            entity.Property(e => e.Batch).IsFixedLength();
            entity.Property(e => e.Status).IsFixedLength();
        });

        modelBuilder.Entity<EinvoiceDataM>(entity =>
        {
            entity.HasKey(e => e.InventoryTransUid).HasName("EINVOICEDATAM_PK");
        });

        modelBuilder.Entity<EjvacknoUpdation>(entity =>
        {
            entity.HasKey(e => e.EjvacknowledgeUpdationUid).HasFillFactor(80);

            entity.ToTable("EJVAcknoUpdation", tb => tb.HasTrigger("TI_EJVAcknowledgeUpdationUID"));

            entity.HasIndex(e => new { e.FinancialYearUid, e.QuarterUid }, "UK_EJVAcknoUpdation")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.AcknowledgementNo, "UK_EJVAcknoUpdation2")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.EjvacknowledgeUpdationUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EjvchallanUpdate>(entity =>
        {
            entity.HasKey(e => e.EjvchallanUid).HasFillFactor(80);

            entity.Property(e => e.EjvchallanUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EjvvoucherUpdation>(entity =>
        {
            entity.HasKey(e => e.EjvvoucherUpdationUid).HasFillFactor(30);

            entity.Property(e => e.EjvvoucherUpdationUid).ValueGeneratedNever();

            entity.HasOne(d => d.VoucherHeaderU).WithMany(p => p.EjvvoucherUpdations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EJVVoucherUpdation_VoucherHeader");
        });

        modelBuilder.Entity<EmployeeAnnualLeaveM>(entity =>
        {
            entity.Property(e => e.EmployeeAnnualLeaveUid).ValueGeneratedNever();

            entity.HasOne(d => d.CalenderYearU).WithMany(p => p.EmployeeAnnualLeaveMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeAnnualLeaveM_CalenderYearM");

            entity.HasOne(d => d.EmployeeU).WithMany(p => p.EmployeeAnnualLeaveMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeAnnualLeaveM_TAEmployeeM");

            entity.HasOne(d => d.LeaveTypeU).WithMany(p => p.EmployeeAnnualLeaveMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeAnnualLeaveM_LeaveTypeM");
        });

        modelBuilder.Entity<EmployeeLeaveDetail>(entity =>
        {
            entity.Property(e => e.EmployeeLeaveDetailsUid).ValueGeneratedNever();

            entity.HasOne(d => d.EmployeeAnnualLeaveU).WithMany(p => p.EmployeeLeaveDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeLeaveDetails_EmployeeAnnualLeaveM");
        });

        modelBuilder.Entity<EnquiryM>(entity =>
        {
            entity.HasKey(e => e.EnquiryMuid).HasFillFactor(80);

            entity.ToTable("EnquiryM", tb => tb.HasTrigger("TI_InsertPartyM"));

            entity.Property(e => e.EnquiryMuid).ValueGeneratedNever();
            entity.Property(e => e.AreaUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.EnquiryType).IsFixedLength();
        });

        modelBuilder.Entity<EwaybillDataM>(entity =>
        {
            entity.HasKey(e => e.Irn).HasName("EWaybillDataM_PK");
        });

        modelBuilder.Entity<FarmersM>(entity =>
        {
            entity.Property(e => e.FarmerUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<FekycmasterM>(entity =>
        {
            entity.HasKey(e => e.ReqEmpUid)
                .HasName("PK_Kyc_Master")
                .HasFillFactor(90);

            entity.Property(e => e.ReqEmpUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<FekycrequestM>(entity =>
        {
            entity.HasKey(e => e.ReqEmpUid).HasName("PK_Kyc_Form");

            entity.Property(e => e.ReqEmpUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<FieldInspectionReportM>(entity =>
        {
            entity.Property(e => e.FieldInspectionReportUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<FinancialYearM>(entity =>
        {
            entity.HasKey(e => e.FinancialYearUid).HasFillFactor(80);

            entity.Property(e => e.FinancialYearUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<FollowUpDetail>(entity =>
        {
            entity.HasKey(e => e.FollowUpDetailUid).HasFillFactor(80);

            entity.Property(e => e.FollowUpDetailUid).ValueGeneratedNever();

            entity.HasOne(d => d.EnquiryMu).WithMany(p => p.FollowUpDetails).HasConstraintName("FK_FollowUpDetail_EnquiryM");

            entity.HasOne(d => d.PartyU).WithMany(p => p.FollowUpDetails).HasConstraintName("FK_FollowUpDetail_PartyM");
        });

        modelBuilder.Entity<FormFentry>(entity =>
        {
            entity.HasKey(e => e.FormFentryUid).HasFillFactor(80);

            entity.Property(e => e.FormFentryUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<FreeItemM>(entity =>
        {
            entity.HasKey(e => e.FreeItemMuid).HasFillFactor(80);

            entity.Property(e => e.FreeItemMuid).ValueGeneratedNever();

            entity.HasOne(d => d.SelectedItemU).WithMany(p => p.FreeItemMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FreeItemM_ItemM");
        });

        modelBuilder.Entity<FreeItemQty>(entity =>
        {
            entity.HasKey(e => e.FreeItemQtyUid).HasFillFactor(80);

            entity.Property(e => e.FreeItemQtyUid).ValueGeneratedNever();

            entity.HasOne(d => d.FreeItemMu).WithMany(p => p.FreeItemQties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FreeItemQty_FreeItemM");

            entity.HasOne(d => d.FreeItemU).WithMany(p => p.FreeItemQties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FreeItemQty_ItemM");
        });

        modelBuilder.Entity<FreeTransLink>(entity =>
        {
            entity.HasKey(e => e.FreeTransLinkUid).HasFillFactor(80);
        });

        modelBuilder.Entity<FreightChargesM>(entity =>
        {
            entity.HasKey(e => e.FreightChargesUid).HasFillFactor(30);

            entity.Property(e => e.FreightChargesUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.FreightChargesMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchM_FreightChargesM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.FreightChargesMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemM_FreightChargesM");
        });

        modelBuilder.Entity<FrieghtPaymentTypeM>(entity =>
        {
            entity.HasKey(e => e.FrieghtPaymentTypeUid).HasFillFactor(80);

            entity.Property(e => e.FrieghtPaymentTypeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<FrtCharge>(entity =>
        {
            entity.ToView("FRT_CHARGES");
        });

        modelBuilder.Entity<GeneralLedgerView>(entity =>
        {
            entity.ToView("GeneralLedgerView");
        });

        modelBuilder.Entity<GlcategoryM>(entity =>
        {
            entity.HasKey(e => e.GlcategoryUid).HasFillFactor(80);

            entity.Property(e => e.GlcategoryUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<GlpostingStatusM>(entity =>
        {
            entity.HasKey(e => e.GlpostingStatusUid).HasFillFactor(80);

            entity.Property(e => e.GlpostingStatusUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<GracePeriodForBackDaysEntry>(entity =>
        {
            entity.HasKey(e => e.GraceperiodforbackdaysUid).HasFillFactor(30);

            entity.Property(e => e.GraceperiodforbackdaysUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Grnamendment>(entity =>
        {
            entity.HasKey(e => e.GrnamendmentUid).HasFillFactor(30);

            entity.Property(e => e.GrnamendmentUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<GrncashPurchaseItemM>(entity =>
        {
            entity.HasKey(e => e.GrncashPurchaseUid).HasFillFactor(30);

            entity.HasIndex(e => e.ItemCode, "UK_GRNCashPurchaseItemM")
                .IsUnique()
                .HasFillFactor(30);

            entity.Property(e => e.GrncashPurchaseUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<GrnoutsourceMapping>(entity =>
        {
            entity.HasKey(e => e.GrnoutsourceMappingUid).HasFillFactor(80);

            entity.HasIndex(e => new { e.GrnlistUid, e.OslistUid }, "UK_GRNOutsourceMapping")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.GrnoutsourceMappingUid).ValueGeneratedNever();

            entity.HasOne(d => d.GrnlistU).WithMany(p => p.GrnoutsourceMappingGrnlistUs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRNOutsourceMapping_InventoryTransList");

            entity.HasOne(d => d.OslistU).WithMany(p => p.GrnoutsourceMappingOslistUs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GRNOutsourceMapping_InventoryTransList1");
        });

        modelBuilder.Entity<GrossMarginEdvatMappingM>(entity =>
        {
            entity.HasOne(d => d.AccountU).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GrossMargin_EDVatMappingM_AccountM");

            entity.HasOne(d => d.ItemSubGroupU).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GrossMargin_EDVatMappingM_ItemSubGroupM");

            entity.HasOne(d => d.ParentAccountU).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GrossMargin_EDVatMappingM_AccountM1");
        });

        modelBuilder.Entity<GstexpDetail>(entity =>
        {
            entity.Property(e => e.GstexpDetailsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<HelpM>(entity =>
        {
            entity.HasKey(e => e.HelpMuid).HasFillFactor(80);

            entity.HasIndex(e => e.FormUid, "IX_HelpM")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.HelpMuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<HoapprovedDrcrnote>(entity =>
        {
            entity.HasKey(e => e.HoapprovedDrcrnotesUid).HasFillFactor(80);

            entity.Property(e => e.HoapprovedDrcrnotesUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Hoapprovedatum>(entity =>
        {
            entity.HasKey(e => e.HoapproveDataGuid).HasFillFactor(90);

            entity.Property(e => e.HoapproveDataGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<HotoApproveDatum>(entity =>
        {
            entity.HasKey(e => e.HotoApproveDataGuid).HasFillFactor(90);

            entity.Property(e => e.HotoApproveDataGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<HsnaccountMappingM>(entity =>
        {
            entity.Property(e => e.HsnaccountMappingUid).ValueGeneratedNever();

            entity.HasOne(d => d.AccountU).WithMany(p => p.HsnaccountMappingMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HSNAccountMappingM_AccountM");

            entity.HasOne(d => d.HsncodeU).WithMany(p => p.HsnaccountMappingMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HSNAccountMappingM_HSNCodeM");
        });

        modelBuilder.Entity<HsncodeM>(entity =>
        {
            entity.Property(e => e.HsncodeUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.HsncodeMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HSNCodeM_BranchM");
        });

        modelBuilder.Entity<IbtaccountSync>(entity =>
        {
            entity.HasKey(e => e.IbtaccountSyncUid).HasFillFactor(90);

            entity.Property(e => e.IbtaccountSyncUid).ValueGeneratedNever();
            entity.Property(e => e.AccountProperty).IsFixedLength();
        });

        modelBuilder.Entity<InOutRegisterMfNew>(entity =>
        {
            entity.HasKey(e => e.RowUid)
                .HasName("PK_InOutRegisterMf_New")
                .HasFillFactor(80);

            entity.Property(e => e.RowUid).ValueGeneratedNever();
            entity.Property(e => e.Remarks).IsFixedLength();
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InOutRegisterNew>(entity =>
        {
            entity.HasKey(e => e.RowUid).HasFillFactor(80);

            entity.Property(e => e.RowUid).ValueGeneratedNever();
            entity.Property(e => e.Remarks).IsFixedLength();
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<IndexMaintenanceHistory>(entity =>
        {
            entity.HasKey(e => e.IndexCommandId).HasFillFactor(80);
        });

        modelBuilder.Entity<Inoutregister>(entity =>
        {
            entity.ToTable("inoutregister", tb => tb.HasTrigger("Tr_inoutregister"));

            entity.HasIndex(e => new { e.BranchCode, e.TransactionType, e.ItemCode }, "IX_inoutregister1").HasFillFactor(80);

            entity.HasIndex(e => new { e.BranchCode, e.TransactionType, e.ItemCode, e.Sno }, "IX_inoutregister2").HasFillFactor(80);

            entity.HasIndex(e => new { e.BranchCode, e.TransactionType, e.ItemCode, e.RowId }, "IX_inoutregister3").HasFillFactor(80);

            entity.HasIndex(e => e.RowId, "IX_inoutregister4").HasFillFactor(80);

            entity.HasIndex(e => new { e.BranchCode, e.ItemCode, e.Date }, "IX_inoutregister5").HasFillFactor(80);

            entity.HasIndex(e => e.Sno, "IX_inoutregister6").HasFillFactor(80);

            entity.HasIndex(e => new { e.ItemCode, e.BranchCode }, "IX_inoutregister7").HasFillFactor(80);

            entity.HasIndex(e => new { e.BranchCode, e.ItemCode, e.Date, e.TransactionType }, "IX_inoutregister8").HasFillFactor(80);

            entity.Property(e => e.Remark).IsFixedLength();
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Inoutregistermf>(entity =>
        {
            entity.ToTable("inoutregistermf", tb => tb.HasTrigger("Tr_InOutRegisterMF"));

            entity.Property(e => e.Remark).IsFixedLength();
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Inoutregistermfmirror>(entity =>
        {
            entity.Property(e => e.Remark).IsFixedLength();
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Inoutregistermirror>(entity =>
        {
            entity.Property(e => e.Remark).IsFixedLength();
            entity.Property(e => e.Sno).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<InventoryServiceTran>(entity =>
        {
            entity.HasKey(e => e.InventoryTransUid)
                .HasName("PK_InventoryTransServices")
                .HasFillFactor(80);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("TI_DocumentNoForService");
                    tb.HasTrigger("TI_InventoryServiceTransUID");
                });

            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsFirstSale).HasDefaultValue(true);
            entity.Property(e => e.PrintFlag).HasDefaultValue(false);
            entity.Property(e => e.SecondarySupplierUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AreaSou).WithMany(p => p.InventoryServiceTrans).HasConstraintName("FK_InventoryTransServices_AreaSOMapping");

            entity.HasOne(d => d.BranchU).WithMany(p => p.InventoryServiceTrans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransServices_BranchM");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.InventoryServiceTrans).HasConstraintName("FK_InventoryTransServices_DivisionPrincipleM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.InventoryServiceTrans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransServices_DivisionM");

            entity.HasOne(d => d.FrieghtPaymentTypeU).WithMany(p => p.InventoryServiceTrans).HasConstraintName("FK_InventoryTransServices_FrieghtPaymentTypeM");

            entity.HasOne(d => d.PartyShipToU).WithMany(p => p.InventoryServiceTrans).HasConstraintName("FK_InventoryTransServices_PartyShipTo");

            entity.HasOne(d => d.PartyU).WithMany(p => p.InventoryServiceTrans).HasConstraintName("FK_InventoryTransServices_PartyM");

            entity.HasOne(d => d.SecondarySupplierU).WithMany(p => p.InventoryServiceTrans).HasConstraintName("FK_InventoryTransServices_SecondarySupplierM");

            entity.HasOne(d => d.StatusU).WithMany(p => p.InventoryServiceTrans).HasConstraintName("FK_InventoryTransServices_StatusM");

            entity.HasOne(d => d.TransactiontypesU).WithMany(p => p.InventoryServiceTrans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransServices_TransactionTypesM");
        });

        modelBuilder.Entity<InventoryServiceTransList>(entity =>
        {
            entity.HasKey(e => e.InventoryTransListUid).HasFillFactor(80);

            entity.ToTable("InventoryServiceTransList", tb => tb.HasTrigger("TI_InventoryServiceTransListUID"));

            entity.HasOne(d => d.InventoryTransU).WithMany(p => p.InventoryServiceTransLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryServiceTransList_InventoryTrans");

            entity.HasOne(d => d.ItemStatusU).WithMany(p => p.InventoryServiceTransLists).HasConstraintName("FK_InventoryServiceTransList_ItemStatusM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.InventoryServiceTransLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryServiceTransList_ItemM");
        });

        modelBuilder.Entity<InventoryTran>(entity =>
        {
            entity.HasKey(e => e.InventoryTransUid).HasFillFactor(80);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("BranchPoReceipt");
                    tb.HasTrigger("CostCalculation");
                    tb.HasTrigger("TI_DocumentNo");
                    tb.HasTrigger("TI_InsertInventoryTransRequestSlNos_InventoryTrans");
                    tb.HasTrigger("TI_InventoryTransUID");
                    tb.HasTrigger("TI_Validate_InventoryTrans_DocNo");
                });

            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsFirstSale).HasDefaultValue(true);
            entity.Property(e => e.PrintFlag).HasDefaultValue(false);
            entity.Property(e => e.SecondarySupplierUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AreaSou).WithMany(p => p.InventoryTrans).HasConstraintName("FK_InventoryTrans_AreaSOMapping");

            entity.HasOne(d => d.BranchU).WithMany(p => p.InventoryTrans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTrans_BranchM");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.InventoryTrans).HasConstraintName("FK_InventoryTrans_DivisionPrincipleM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.InventoryTrans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTrans_DivisionM");

            entity.HasOne(d => d.FrieghtPaymentTypeU).WithMany(p => p.InventoryTrans).HasConstraintName("FK_InventoryTrans_FrieghtPaymentTypeM");

            entity.HasOne(d => d.PartyShipToU).WithMany(p => p.InventoryTrans).HasConstraintName("FK_InventoryTrans_PartyShipTo");

            entity.HasOne(d => d.PartyU).WithMany(p => p.InventoryTrans).HasConstraintName("FK_InventoryTrans_PartyM");

            entity.HasOne(d => d.SecondarySupplierU).WithMany(p => p.InventoryTrans).HasConstraintName("FK_InventoryTrans_SecondarySupplierM");

            entity.HasOne(d => d.StatusU).WithMany(p => p.InventoryTrans).HasConstraintName("FK_InventoryTrans_StatusM");

            entity.HasOne(d => d.TransactiontypesU).WithMany(p => p.InventoryTrans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTrans_TransactionTypesM");
        });

        modelBuilder.Entity<InventoryTransExtn>(entity =>
        {
            entity.HasKey(e => e.InventoryTransUid).HasFillFactor(90);
        });

        modelBuilder.Entity<InventoryTransList>(entity =>
        {
            entity.HasKey(e => e.InventoryTransListUid).HasFillFactor(80);

            entity.ToTable("InventoryTransList", tb =>
                {
                    tb.HasTrigger("TI_ChectSalesMFGAndExpDate");
                    tb.HasTrigger("TI_ChectSalesREturnQty");
                    tb.HasTrigger("TI_GenerateBatchNo");
                    tb.HasTrigger("TI_InventoryTransListStockCheck");
                    tb.HasTrigger("TI_InventoryTransListUID");
                    tb.HasTrigger("TI_UpdateBranchTransferReceipt");
                    tb.HasTrigger("UpdateGoodsReceiptsToBranchPOtoReceive");
                });

            entity.HasOne(d => d.InventoryTransU).WithMany(p => p.InventoryTransLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransList_InventoryTrans");

            entity.HasOne(d => d.ItemStatusU).WithMany(p => p.InventoryTransLists).HasConstraintName("FK_InventoryTransList_ItemStatusM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.InventoryTransLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryTransList_ItemM");
        });

        modelBuilder.Entity<InventoryTransListExtn>(entity =>
        {
            entity.HasKey(e => e.InventoryTransListUid).HasFillFactor(90);

            entity.ToTable("InventoryTransListExtn", tb => tb.HasTrigger("TI_UpdateEDInBranchTransferReceipt"));
        });

        modelBuilder.Entity<InventoryTransRequestSlNo>(entity =>
        {
            entity.HasKey(e => new { e.BranchUid, e.TransactiontypesUid, e.FinYr, e.DivisionUid }).HasFillFactor(80);

            entity.ToTable(tb => tb.HasTrigger("TR_InventoryTransRequestSlNos"));
        });

        modelBuilder.Entity<IssueReportingM>(entity =>
        {
            entity.HasKey(e => e.IssueReportingUid).HasFillFactor(80);

            entity.Property(e => e.IssueReportingUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemCategoryM>(entity =>
        {
            entity.HasKey(e => e.ItemCategoryUid).HasFillFactor(80);

            entity.HasIndex(e => e.ItemCategoryCode, "IX_ItemCategoryCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ItemCategoryUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ItemCodeSlno>(entity =>
        {
            entity.HasKey(e => new { e.DivisionUid, e.ItemSegmentUid, e.ItemCategoryUid }).HasFillFactor(80);
        });

        modelBuilder.Entity<ItemCommodity>(entity =>
        {
            entity.HasKey(e => e.ItemCommodityUid).HasFillFactor(90);

            entity.Property(e => e.ItemCommodityUid).ValueGeneratedNever();
            entity.Property(e => e.CommodityUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CommodityU).WithMany(p => p.ItemCommodities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCommodity_CommodityCodeM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemCommodities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemCommodity_ItemM");
        });

        modelBuilder.Entity<ItemDivisionLink>(entity =>
        {
            entity.HasKey(e => e.ItemDivisionLinkUid).HasFillFactor(90);

            entity.ToTable("ItemDivisionLink", tb =>
                {
                    tb.HasTrigger("TI_InsertLastNoInItemCodeSlnos_ItemDivisionLink");
                    tb.HasTrigger("TI_InsertLastNoInItemRequestSlNo_ItemDivisionLink");
                });

            entity.HasIndex(e => new { e.ItemUid, e.DivisionUid }, "IX_ItemDivisionLink")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ItemDivisionLinkUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.ItemDivisionLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemDivisionLink_DivisionM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemDivisionLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemDivisionLink_ItemM");
        });

        modelBuilder.Entity<ItemDivisionPrincipleLink>(entity =>
        {
            entity.HasKey(e => e.ItemDivisionPrincipleLinkUid)
                .HasName("PK_ItemDivisionPrincipleLink_1")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.ItemUid, e.DivisionUid, e.DivisionPrincipleUid }, "IX_ItemDivisionPrincipleLink").HasFillFactor(90);

            entity.Property(e => e.ItemDivisionPrincipleLinkUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.ItemDivisionPrincipleLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemdivisionPrincipleLink_DivisionPrincipleM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemDivisionPrincipleLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemdivisionPrincipleLink_ItemM");
        });

        modelBuilder.Entity<ItemGroupM>(entity =>
        {
            entity.HasKey(e => e.ItemGroupUid)
                .HasName("PK_ProductGroup")
                .HasFillFactor(80);

            entity.HasIndex(e => e.ItemGroupCode, "Uq_ItemGroupCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ItemGroupUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ItemSegmentU).WithMany(p => p.ItemGroupMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductGroup_ProductSegment");
        });

        modelBuilder.Entity<ItemInterested>(entity =>
        {
            entity.HasKey(e => e.ItemInterestedUid).HasFillFactor(80);

            entity.Property(e => e.ItemInterestedUid).ValueGeneratedNever();

            entity.HasOne(d => d.PartyU).WithMany(p => p.ItemInteresteds).HasConstraintName("FK_ItemInterested_PartyM");
        });

        modelBuilder.Entity<ItemM>(entity =>
        {
            entity.HasKey(e => e.ItemUid)
                .HasName("PK_ItemRequestM")
                .HasFillFactor(90);

            entity.ToTable("ItemM", tb =>
                {
                    tb.HasTrigger("CreateRegularConsignmentItems");
                    tb.HasTrigger("TI_InsertIntoItemTaxStatusM");
                    tb.HasTrigger("TI_RejectedItemInsert");
                });

            entity.HasIndex(e => e.ItemCode, "IX_ItemCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.ItemCode, "IX_item_master_M").HasFillFactor(80);

            entity.Property(e => e.ItemUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ChemicalUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ConversionFactor).HasDefaultValue(1m);
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Uomuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BranchU).WithMany(p => p.ItemMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestM_BranchM");

            entity.HasOne(d => d.ChemicalU).WithMany(p => p.ItemMs).HasConstraintName("FK_ItemM_ChemicalM1");

            entity.HasOne(d => d.ItemCategoryU).WithMany(p => p.ItemMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestM_ItemCategoryM");

            entity.HasOne(d => d.ItemGroupU).WithMany(p => p.ItemMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestM_ProductGroup");

            entity.HasOne(d => d.ItemSegmentU).WithMany(p => p.ItemMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestM_ProductSegment");

            entity.HasOne(d => d.ItemSubGroupU).WithMany(p => p.ItemMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestM_ProductSubGroup");

            entity.HasOne(d => d.StatusU).WithMany(p => p.ItemMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemM_StatusM");

            entity.HasOne(d => d.Uom2u).WithMany(p => p.ItemMUom2us).HasConstraintName("FK_ItemRequestM_UOMM2");

            entity.HasOne(d => d.Uomu).WithMany(p => p.ItemMUomus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestM_UOMM");
        });

        modelBuilder.Entity<ItemMasterM>(entity =>
        {
            entity.ToView("item_Master_m");
        });

        modelBuilder.Entity<ItemPrincipleSerialNoLink>(entity =>
        {
            entity.HasKey(e => e.ItemPrincipleSerialNoLinkUid).HasFillFactor(90);

            entity.Property(e => e.ItemPrincipleSerialNoLinkUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemPrincipleSerialNoLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPrincipleSerialNoLink_ItemM");

            entity.HasOne(d => d.PrincipleSerialNumberU).WithMany(p => p.ItemPrincipleSerialNoLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemPrincipleSerialNoLink_PrincipleSerialNumber");
        });

        modelBuilder.Entity<ItemRate>(entity =>
        {
            entity.HasKey(e => e.ItemRateUid).HasFillFactor(90);

            entity.Property(e => e.ItemRateUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemRateHeaderU).WithMany(p => p.ItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRate_ItemRateHeader");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRate_ItemM");
        });

        modelBuilder.Entity<ItemRateHeader>(entity =>
        {
            entity.HasKey(e => e.ItemRateHeaderUid)
                .HasName("PK_ItemRateM")
                .HasFillFactor(90);

            entity.ToTable("ItemRateHeader", tb => tb.HasTrigger("Trg_IsProcessedItemRateHeader"));

            entity.HasIndex(e => e.ItemRateDesc, "UQ_ItemRateHeader")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ItemRateHeaderUid).ValueGeneratedNever();
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ItemRateTypeM>(entity =>
        {
            entity.HasKey(e => e.ItemRateTypeUid).HasFillFactor(80);

            entity.HasIndex(e => e.RateTypeCode, "UQ_RateTypeCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.RateTypeDesc, "UQ_RateTypeDesc")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ItemRateTypeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemRequestPack>(entity =>
        {
            entity.HasKey(e => e.ItemRequestPackUid).HasFillFactor(90);

            entity.Property(e => e.ItemRequestPackUid).ValueGeneratedNever();
            entity.Property(e => e.PackUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemRequestPacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestPack_ItemRequestM");

            entity.HasOne(d => d.PackU).WithMany(p => p.ItemRequestPacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemRequestPack_PackM");
        });

        modelBuilder.Entity<ItemRequestRejection>(entity =>
        {
            entity.HasKey(e => e.ItemRequestRejectionUid).HasFillFactor(80);

            entity.Property(e => e.ItemRequestRejectionUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Uomuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ItemRequestSlNo>(entity =>
        {
            entity.HasKey(e => new { e.BranchUid, e.FinYear }).HasFillFactor(80);

            entity.ToTable("ItemRequestSlNo", tb => tb.HasTrigger("TR_ItemRequestSlNo"));
        });

        modelBuilder.Entity<ItemSeedM>(entity =>
        {
            entity.HasKey(e => e.ItemSeedUid).HasFillFactor(90);

            entity.Property(e => e.ItemSeedUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemSeedMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemSeedM_ItemM");

            entity.HasOne(d => d.SeedCategoryU).WithMany(p => p.ItemSeedMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemSeedM_SeedCategoryM");

            entity.HasOne(d => d.SeedTypeU).WithMany(p => p.ItemSeedMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemSeedM_SeedTypeM");

            entity.HasOne(d => d.SeedVarietyU).WithMany(p => p.ItemSeedMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemSeedM_SeedVarietyM");
        });

        modelBuilder.Entity<ItemSegmentM>(entity =>
        {
            entity.HasKey(e => e.ItemSegmentUid)
                .HasName("PK_ProductSegmentM")
                .HasFillFactor(80);

            entity.HasIndex(e => e.ItemSegmentCode, "IX_ItemSegmentCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ItemSegmentUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemSpecificationM>(entity =>
        {
            entity.HasKey(e => e.ItemSpecificationUid).HasFillFactor(30);

            entity.Property(e => e.ItemSpecificationUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemStatusM>(entity =>
        {
            entity.HasKey(e => e.ItemStatusUid).HasFillFactor(80);

            entity.Property(e => e.ItemStatusUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ItemSubGroupM>(entity =>
        {
            entity.HasKey(e => e.ItemSubGroupUid)
                .HasName("PK_ProductSubGroup")
                .HasFillFactor(90);

            entity.HasIndex(e => e.ItemSubGroupCode, "IX_ItemSubGroupCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ItemSubGroupUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemGroupU).WithMany(p => p.ItemSubGroupMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductSubGroup_ProductGroup");
        });

        modelBuilder.Entity<ItemSupplierLink>(entity =>
        {
            entity.HasKey(e => e.ItemSupplierLinkUid).HasFillFactor(80);

            entity.ToTable("ItemSupplierLink", tb => tb.HasTrigger("TI_ItemSupplierLinkUID"));

            entity.HasIndex(e => new { e.PartyUid, e.ItemUid }, "UK_ItemSupplierLink").HasFillFactor(80);

            entity.Property(e => e.ItemSupplierLinkUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemU).WithMany(p => p.ItemSupplierLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemSupplierLink_ItemM");

            entity.HasOne(d => d.PartyU).WithMany(p => p.ItemSupplierLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemSupplierLink_PartyM");
        });

        modelBuilder.Entity<ItemWiseSalesOrderLink>(entity =>
        {
            entity.HasKey(e => e.ItemWiseSalesOrderLinkUid).HasName("PK_ItemWiseSalesOrdeLink");

            entity.ToTable("ItemWiseSalesOrderLink", tb => tb.HasTrigger("TI_ItemWisePendingSalesOrderCheck"));

            entity.Property(e => e.ItemWiseSalesOrderLinkUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemWiseStorageDetail>(entity =>
        {
            entity.HasKey(e => e.ItemwiseStorageDetailsUid).HasName("PK_ItemwiseStorageDetails");

            entity.Property(e => e.ItemwiseStorageDetailsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItsectionM>(entity =>
        {
            entity.HasKey(e => e.ItsectionUid).HasFillFactor(80);

            entity.Property(e => e.ItsectionUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<LeaveTypeM>(entity =>
        {
            entity.Property(e => e.LeaveTypeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<LedgerTemplateMappingM>(entity =>
        {
            entity.HasKey(e => e.LedgerTemplateMappingUid)
                .HasName("PK_LedgerTemplateMapping")
                .HasFillFactor(90);

            entity.Property(e => e.LedgerTemplateMappingUid).ValueGeneratedNever();

            entity.HasOne(d => d.AffectedAccountTypesU).WithMany(p => p.LedgerTemplateMappingMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LedgerTemplateMapping_AffectedAccountTypesM");

            entity.HasOne(d => d.LedgerTemplatesU).WithMany(p => p.LedgerTemplateMappingMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LedgerTemplateMappingM_LedgerTemplatesM");
        });

        modelBuilder.Entity<LedgerTemplatesM>(entity =>
        {
            entity.HasKey(e => e.LedgerTemplatesUid).HasFillFactor(80);

            entity.Property(e => e.LedgerTemplatesUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TransactiontypesU).WithMany(p => p.LedgerTemplatesMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LedgerTemplatesM_TransactionTypesM");
        });

        modelBuilder.Entity<LiveMonthYear>(entity =>
        {
            entity.HasKey(e => e.LiveMonthYearUid).HasFillFactor(80);

            entity.Property(e => e.LiveMonthYearUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<MenusM>(entity =>
        {
            entity.HasKey(e => e.MenuUid).HasFillFactor(90);

            entity.ToTable("MenusM", tb => tb.HasTrigger("TI_MenusM"));

            entity.Property(e => e.MenuUid).ValueGeneratedNever();
            entity.Property(e => e.MenuType)
                .HasDefaultValue("")
                .IsFixedLength();
        });

        modelBuilder.Entity<MonthEndProcedureM>(entity =>
        {
            entity.HasKey(e => e.MonthEndProcedureUid).HasFillFactor(80);

            entity.Property(e => e.MonthEndProcedureUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonthendProcedureCheckList>(entity =>
        {
            entity.HasKey(e => e.MonthEndProcedureCheckListUid).HasFillFactor(80);

            entity.Property(e => e.MonthEndProcedureCheckListUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Moqm>(entity =>
        {
            entity.Property(e => e.Moquid).ValueGeneratedNever();
        });

        modelBuilder.Entity<OneTimeAddress>(entity =>
        {
            entity.HasKey(e => e.OneTimeAddressUid).HasFillFactor(90);

            entity.Property(e => e.OneTimeAddressUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<OpeningRatesCipd>(entity =>
        {
            entity.HasKey(e => e.InventoryTransListUid).HasFillFactor(90);
        });

        modelBuilder.Entity<OverdueDaysM>(entity =>
        {
            entity.HasKey(e => e.OverDueDaysMuid)
                .HasName("PK_OVerduedaysM")
                .HasFillFactor(80);

            entity.Property(e => e.OverDueDaysMuid).ValueGeneratedNever();

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.OverdueDaysMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OVerduedaysM_DivisionPrincipleM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.OverdueDaysMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OVerduedaysM_DivisionM");
        });

        modelBuilder.Entity<PackM>(entity =>
        {
            entity.HasKey(e => e.PackUid).HasFillFactor(90);

            entity.HasIndex(e => new { e.DivisionUid, e.PackCode }, "IX_PackM")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.PackUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.PricePerUnit).HasDefaultValue(0m);

            entity.HasOne(d => d.DivisionU).WithMany(p => p.PackMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PackM_DivisionM");
        });

        modelBuilder.Entity<PackingM>(entity =>
        {
            entity.ToView("packing_m");
        });

        modelBuilder.Entity<PartiesM>(entity =>
        {
            entity.ToView("Parties_M");
        });

        modelBuilder.Entity<PartyAddressDetailsBranchRequest>(entity =>
        {
            entity.ToTable("PartyAddressDetailsBranchRequest", tb => tb.HasTrigger("TI_PartyAddressDetailsBranchRequestNo"));

            entity.Property(e => e.RequestPartyAddressDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyAddressDetailsHoapproval>(entity =>
        {
            entity.Property(e => e.ApprovedPartyAddressDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyBankDetailsBranchRequest>(entity =>
        {
            entity.ToTable("PartyBankDetailsBranchRequest", tb => tb.HasTrigger("TI_PartyBankDetailsBranchRequestNo"));

            entity.Property(e => e.RequestPartyBankDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyBankDetailsHoapproval>(entity =>
        {
            entity.Property(e => e.ApprovedPartyBankDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyCodeSlNo>(entity =>
        {
            entity.HasKey(e => new { e.StateUid, e.BranchUid, e.Letter }).HasFillFactor(90);

            entity.Property(e => e.Letter).IsFixedLength();
        });

        modelBuilder.Entity<PartyCreditLimitBranchRequest>(entity =>
        {
            entity.ToTable("PartyCreditLimitBranchRequest", tb => tb.HasTrigger("TI_PartyCreditLimitBranchRequestNo"));

            entity.Property(e => e.RequestPartyCreditLimitUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyCreditLimitHistory>(entity =>
        {
            entity.HasKey(e => e.PartyCreditLimitHistoryUid).HasFillFactor(80);

            entity.Property(e => e.PartyCreditLimitHistoryUid).ValueGeneratedNever();
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.PartyCreditLimitU).WithMany(p => p.PartyCreditLimitHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyCreditLimit_PartyCreditLimitHistory");
        });

        modelBuilder.Entity<PartyCreditLimitHoapproval>(entity =>
        {
            entity.Property(e => e.ApprovedPartyCreditLimitUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyCreditLimitM>(entity =>
        {
            entity.HasKey(e => e.PartyCreditLimitUid).HasFillFactor(90);

            entity.Property(e => e.PartyCreditLimitUid).ValueGeneratedNever();
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.PartyCreditLimitMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyCreditLimitM_DivisionPrincipleM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.PartyCreditLimitMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyCreditLimitM_DivisionM");

            entity.HasOne(d => d.FinancialYearU).WithMany(p => p.PartyCreditLimitMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyCreditLimitM_FinancialYearM");

            entity.HasOne(d => d.PartyU).WithMany(p => p.PartyCreditLimitMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyCreditLimitM_PartyM");
        });

        modelBuilder.Entity<PartyM>(entity =>
        {
            entity.HasKey(e => e.PartyUid)
                .HasName("PK_PartyRequest")
                .HasFillFactor(90);

            entity.ToTable("PartyM", tb =>
                {
                    tb.HasTrigger("OnPartyInsert");
                    tb.HasTrigger("RequestPartyM_Tr");
                    tb.HasTrigger("TI_InsertLastNoInPartyRequestSlNo");
                    tb.HasTrigger("TI_PartyCodeSlnos");
                    tb.HasTrigger("TU_RejectedPartiesToRejectedPartyM");
                });

            entity.HasIndex(e => e.PartyCode, "IX_PartyCode")
                .IsUnique()
                .HasFilter("([PartyCode] IS NOT NULL)")
                .HasFillFactor(80);

            entity.Property(e => e.PartyUid).ValueGeneratedNever();
            entity.Property(e => e.AreaUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DealerCategoryUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DealerTypeUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Gstno).HasDefaultValueSql("((0))");
            entity.Property(e => e.PartyTypeUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AreaU).WithMany(p => p.PartyMs).HasConstraintName("FK_PartyM_AreaM");

            entity.HasOne(d => d.BranchU).WithMany(p => p.PartyMs).HasConstraintName("FK_PartyM_BranchM");

            entity.HasOne(d => d.CountryU).WithMany(p => p.PartyMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyM_CountryM");

            entity.HasOne(d => d.DealerCategoryU).WithMany(p => p.PartyMs).HasConstraintName("FK_PartyM_DealerCategoryM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.PartyMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyM_DivisionM");

            entity.HasOne(d => d.PartyTypeU).WithMany(p => p.PartyMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyM_PartyTypeM");

            entity.HasOne(d => d.StateU).WithMany(p => p.PartyMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyM_StateM");

            entity.HasOne(d => d.StatusU).WithMany(p => p.PartyMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyM_StatusM");
        });

        modelBuilder.Entity<PartyOtherDetailsBranchRequest>(entity =>
        {
            entity.ToTable("PartyOtherDetailsBranchRequest", tb => tb.HasTrigger("TI_PartyOtherDetailsBranchRequestNo"));

            entity.Property(e => e.RequestPartyOtherDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyOtherDetailsHoapproval>(entity =>
        {
            entity.Property(e => e.ApprovedPartyOtherDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PartyRequestSlNo>(entity =>
        {
            entity.HasKey(e => new { e.BranchUid, e.FinYear }).HasFillFactor(80);

            entity.ToTable("PartyRequestSlNo", tb => tb.HasTrigger("TR_PartyRequestSlNo"));
        });

        modelBuilder.Entity<PartyShipTo>(entity =>
        {
            entity.HasKey(e => e.PartyShipToUid).HasFillFactor(90);

            entity.ToTable("PartyShipTo", tb =>
                {
                    tb.HasTrigger("RequestPartyShipTo_Tr");
                    tb.HasTrigger("TI_RequestPartyShiptoDetails");
                });

            entity.Property(e => e.PartyShipToUid).ValueGeneratedNever();
            entity.Property(e => e.Gstno).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.PartyU).WithMany(p => p.PartyShipTos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartyRequestShipTo_PartyRequest");
        });

        modelBuilder.Entity<PartyTypeM>(entity =>
        {
            entity.HasKey(e => e.PartyTypeUid).HasFillFactor(80);

            entity.HasIndex(e => e.PartyTypeCode, "IX_PartyTypeCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.PartyTypeUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PayModeM>(entity =>
        {
            entity.HasKey(e => e.ModeUid)
                .HasName("PK_ModeM")
                .HasFillFactor(80);
        });

        modelBuilder.Entity<PcrcancelledDetail>(entity =>
        {
            entity.HasKey(e => e.PcrcancelledUid).HasFillFactor(80);

            entity.Property(e => e.PcrcancelledUid).ValueGeneratedNever();

            entity.HasOne(d => d.Pcru).WithMany(p => p.PcrcancelledDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PCRCancelledDetails_PCRDetails");
        });

        modelBuilder.Entity<Pcrdetail>(entity =>
        {
            entity.HasKey(e => e.Pcruid).HasFillFactor(80);

            entity.HasIndex(e => new { e.Souid, e.BookNo }, "UK_PCRDetails")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Pcruid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PeriodicalDiscountExemptedM>(entity =>
        {
            entity.HasKey(e => e.PeriodicalDiscountExpUid).HasFillFactor(90);

            entity.Property(e => e.PeriodicalDiscountExpUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PhysicalStockVerificationDetail>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockVerificationDetailUid)
                .HasName("PK_PhysicalStockVerificationDetailUID")
                .HasFillFactor(80);

            entity.Property(e => e.PhysicalStockVerificationDetailUid).ValueGeneratedNever();

            entity.HasOne(d => d.PhysicalStockVerificationHeaderU).WithMany(p => p.PhysicalStockVerificationDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicalStockVerificationDetail_PhysicalStockVerificationHeader");
        });

        modelBuilder.Entity<PhysicalStockVerificationEntryDetail>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockVerificationEntryDetailUid)
                .HasName("PK_PhysicalStockVerificationEntryDetail_1")
                .HasFillFactor(90);

            entity.Property(e => e.PhysicalStockVerificationEntryDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PhysicalStockVerificationEntryHeader>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockVerificationEntryHeaderUid).HasFillFactor(30);

            entity.Property(e => e.PhysicalStockVerificationEntryHeaderUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PhysicalStockVerificationHeader>(entity =>
        {
            entity.HasKey(e => e.PhysicalStockVerificationHeaderUid).HasFillFactor(80);

            entity.Property(e => e.PhysicalStockVerificationHeaderUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Podetail>(entity =>
        {
            entity.HasKey(e => e.PolineUid).HasFillFactor(80);

            entity.ToTable("PODetail", tb =>
                {
                    tb.HasTrigger("InsertPODetailToBranchPOToReceive");
                    tb.HasTrigger("TI_POLineUID");
                });

            entity.Property(e => e.AmendMinusQty).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.ItemU).WithMany(p => p.Podetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PODetail_ItemM");

            entity.HasOne(d => d.PoheaderU).WithMany(p => p.Podetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PODetail_POHeader");
        });

        modelBuilder.Entity<Poheader>(entity =>
        {
            entity.HasKey(e => e.PoheaderUid).HasFillFactor(80);

            entity.ToTable("POHeader", tb =>
                {
                    tb.HasTrigger("TI_POHeaderDocumentNo");
                    tb.HasTrigger("TI_POHeaderUID");
                });

            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.Poheaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POHeader_DivisionM");

            entity.HasOne(d => d.RequestedBranchU).WithMany(p => p.Poheaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POHeader_BranchM");

            entity.HasOne(d => d.SupplierU).WithMany(p => p.Poheaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POHeader_PartyM");
        });

        modelBuilder.Entity<Poindent>(entity =>
        {
            entity.HasKey(e => e.PoindentUid).HasFillFactor(90);

            entity.ToTable("POIndent", tb =>
                {
                    tb.HasTrigger("TI_POIndentDocumentNo");
                    tb.HasTrigger("TI_POIndentUID");
                });

            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.Poindents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POIndent_DivisionM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.Poindents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POIndent_ItemM");

            entity.HasOne(d => d.RequestedBranchU).WithMany(p => p.Poindents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POIndent_BranchM");
        });

        modelBuilder.Entity<Poschedule>(entity =>
        {
            entity.HasKey(e => e.PoscheduleUid).HasFillFactor(80);

            entity.ToTable("POSchedule", tb => tb.HasTrigger("TI_POScheduleUID"));

            entity.HasOne(d => d.PolineU).WithMany(p => p.Poschedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_POSchedule_PODetail");
        });

        modelBuilder.Entity<PreDefinedIndentQuery>(entity =>
        {
            entity.HasKey(e => e.QueryUid).HasFillFactor(90);

            entity.Property(e => e.QueryUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<PreferredDealerM>(entity =>
        {
            entity.HasKey(e => e.PreferredDealerUid).HasFillFactor(30);

            entity.Property(e => e.PreferredDealerUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PriceDiscountControlM>(entity =>
        {
            entity.HasKey(e => e.PriceDiscountControlUid).HasFillFactor(30);

            entity.Property(e => e.PriceDiscountControlUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.PriceDiscountControlMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceDiscountControlM_BranchM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.PriceDiscountControlMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceDiscountControlM_DivisionM");
        });

        modelBuilder.Entity<PrincDecl>(entity =>
        {
            entity.Property(e => e.Desc).IsFixedLength();
            entity.Property(e => e.Stat).IsFixedLength();
        });

        modelBuilder.Entity<PrincipleSerialNumber>(entity =>
        {
            entity.HasKey(e => e.PrincipleSerialNumberUid).HasFillFactor(80);

            entity.HasIndex(e => e.PrincipleSerialNoCode, "UK_PrincipleSerialNumber")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.PrincipleSerialNumberUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.PrincipleSerialNumbers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrincipleSerialNumber_DivisionM");
        });

        modelBuilder.Entity<PrintM>(entity =>
        {
            entity.HasKey(e => e.PrintUid).HasFillFactor(30);

            entity.Property(e => e.PrintUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProcessChargesM>(entity =>
        {
            entity.HasKey(e => e.ProcessChargesUid).HasFillFactor(30);

            entity.Property(e => e.ProcessChargesUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemU).WithMany(p => p.ProcessChargesMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProcessChargesM_ItemM");
        });

        modelBuilder.Entity<ProcessInformation>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ProcessedPeriodicalSchemeCreditNote>(entity =>
        {
            entity.HasKey(e => e.ProcessSchemeUid).HasFillFactor(30);

            entity.HasIndex(e => e.SchemeCnrequestUid, "IX_ProcessedPeriodicalSchemeCreditNote")
                .IsUnique()
                .HasFillFactor(30);

            entity.Property(e => e.ProcessSchemeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductPromotionPaymentApproval>(entity =>
        {
            entity.Property(e => e.PpapprovalUid).ValueGeneratedNever();
            entity.Property(e => e.IsActive).IsFixedLength();
        });

        modelBuilder.Entity<ProductPromotionPaymentRequestM>(entity =>
        {
            entity.Property(e => e.PprequestUid).ValueGeneratedNever();
            entity.Property(e => e.IsActive).IsFixedLength();
        });

        modelBuilder.Entity<ProductionLoss>(entity =>
        {
            entity.HasKey(e => e.ProductionLossUid).HasFillFactor(80);

            entity.ToTable("ProductionLoss", tb => tb.HasTrigger("TI_ProductionLossUID"));

            entity.HasOne(d => d.InventoryTransU).WithMany(p => p.ProductionLosses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionLoss_InventoryTrans");
        });

        modelBuilder.Entity<ProductionM>(entity =>
        {
            entity.HasKey(e => e.ProductionUid).HasFillFactor(80);

            entity.Property(e => e.ProductionUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BranchU).WithMany(p => p.ProductionMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionM_BranchM");

            entity.HasOne(d => d.FinishedItemU).WithMany(p => p.ProductionMFinishedItemUs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionM_ItemM");

            entity.HasOne(d => d.RawMatU).WithMany(p => p.ProductionMRawMatUs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionM_ItemM1");
        });

        modelBuilder.Entity<ProductionQrcodeItemDetail>(entity =>
        {
            entity.Property(e => e.ProductionQrcodeItemDetailsUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemU).WithMany(p => p.ProductionQrcodeItemDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductionQRCodeItemDetails_ItemM");
        });

        modelBuilder.Entity<ProformaInvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.ProformaInvoiceDetailUid).HasFillFactor(80);

            entity.Property(e => e.ProformaInvoiceDetailUid).ValueGeneratedNever();

            entity.HasOne(d => d.CurrencyU).WithMany(p => p.ProformaInvoiceDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoiceDetail_CurrencyM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.ProformaInvoiceDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoiceDetail_ItemM");

            entity.HasOne(d => d.ProformaInvoiceHeaderU).WithMany(p => p.ProformaInvoiceDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoiceDetail_ProformaInvoiceHeader");
        });

        modelBuilder.Entity<ProformaInvoiceHeader>(entity =>
        {
            entity.HasKey(e => e.ProformaInvoiceHeaderUid).HasFillFactor(80);

            entity.ToTable("ProformaInvoiceHeader", tb => tb.HasTrigger("TI_ProformaInvoiceDocumentNo"));

            entity.HasIndex(e => e.DocNo, "UK_ProformaInvoiceHeader")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.ProformaInvoiceHeaderUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.ProformaInvoiceHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoiceHeader_BranchM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.ProformaInvoiceHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProformaInvoiceHeader_DivisionM");

            entity.HasOne(d => d.EnquiryPartyU).WithMany(p => p.ProformaInvoiceHeaders).HasConstraintName("FK_ProformaInvoiceHeader_EnquiryM");

            entity.HasOne(d => d.PartyU).WithMany(p => p.ProformaInvoiceHeaders).HasConstraintName("FK_ProformaInvoiceHeader_PartyM");
        });

        modelBuilder.Entity<ProvisionalSchemeCreditNote>(entity =>
        {
            entity.HasKey(e => e.ProvisionalSchemeCreditNote1).HasFillFactor(80);

            entity.Property(e => e.ProvisionalSchemeCreditNote1).ValueGeneratedNever();
            entity.Property(e => e.IsSendToApproval).HasDefaultValue(false);
        });

        modelBuilder.Entity<PurchaseInvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseInvoiceDetailUid).HasFillFactor(80);

            entity.ToTable("PurchaseInvoiceDetail", tb => tb.HasTrigger("TI_PurchaseInvoiceDetailUID"));

            entity.HasOne(d => d.PurchaseInvoiceHeaderU).WithMany(p => p.PurchaseInvoiceDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceDetail_PurchaseInvoiceHeader");
        });

        modelBuilder.Entity<PurchaseInvoiceDetailConsignment>(entity =>
        {
            entity.HasKey(e => e.PurchaseInvoiceDetailConsignmentUid).HasFillFactor(80);

            entity.Property(e => e.PurchaseInvoiceDetailConsignmentUid).ValueGeneratedNever();

            entity.HasOne(d => d.PurchaseInvoiceDetailU).WithMany(p => p.PurchaseInvoiceDetailConsignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceDetailConsignment_PurchaseInvoiceDetail");
        });

        modelBuilder.Entity<PurchaseInvoiceDetailExtn>(entity =>
        {
            entity.HasKey(e => e.PurchaseInvoiceDetailUid).HasFillFactor(80);

            entity.HasOne(d => d.PurchaseInvoiceHeaderU).WithMany(p => p.PurchaseInvoiceDetailExtns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceDetailExtn_PurchaseInvoiceHeader");
        });

        modelBuilder.Entity<PurchaseInvoiceHeader>(entity =>
        {
            entity.HasKey(e => e.PurchaseInvoiceHeaderUid).HasFillFactor(80);

            entity.ToTable("PurchaseInvoiceHeader", tb =>
                {
                    tb.HasTrigger("TI_CostCalculation");
                    tb.HasTrigger("TI_PurchaseInvoiceHeaderUID");
                    tb.HasTrigger("TI_PurchaseInvoiceNo");
                });

            entity.Property(e => e.ClaimSettlement).HasDefaultValue(0m);

            entity.HasOne(d => d.ReceivingBranchU).WithMany(p => p.PurchaseInvoiceHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceHeader_BranchM");

            entity.HasOne(d => d.SupplierU).WithMany(p => p.PurchaseInvoiceHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseInvoiceHeader_PartyM");
        });

        modelBuilder.Entity<PurchaseInvoiceHeaderExtn>(entity =>
        {
            entity.HasKey(e => e.PurchaseInvoiceHeaderUid).HasFillFactor(80);
        });

        modelBuilder.Entity<PurchaseOrderAdvance>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderAdvanceUid).HasFillFactor(80);

            entity.ToTable("PurchaseOrderAdvance", tb => tb.HasTrigger("TI_PurchaseOrderAdvanceUID"));
        });

        modelBuilder.Entity<PurchaseOrderAdvanceAdjustment>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderAdvanceAdjustmentUid).HasFillFactor(80);

            entity.ToTable("PurchaseOrderAdvanceAdjustment", tb => tb.HasTrigger("TI_PurchaseOrderAdvanceAdjustment"));

            entity.HasOne(d => d.PurchaseOrderAdvanceU).WithMany(p => p.PurchaseOrderAdvanceAdjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderAdvanceAdjustment_PurchaseOrderAdvance");

            entity.HasOne(d => d.VoucherHeaderU).WithMany(p => p.PurchaseOrderAdvanceAdjustments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrderAdvanceAdjustment_VoucherHeader");
        });

        modelBuilder.Entity<QtyAdjInfo>(entity =>
        {
            entity.HasIndex(e => new { e.ItemCode, e.BranchCode }, "IX_QtyAdjInfo1").HasFillFactor(80);
        });

        modelBuilder.Entity<QuarterM>(entity =>
        {
            entity.HasKey(e => e.QuarterUid).HasFillFactor(80);

            entity.Property(e => e.QuarterUid).ValueGeneratedNever();
            entity.Property(e => e.QuarterNo).IsFixedLength();
        });

        modelBuilder.Entity<ROverHeadAnalysis>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TranCategory).IsFixedLength();
        });

        modelBuilder.Entity<ROverHeadAnalysisOtherAccount>(entity =>
        {
            entity.Property(e => e.Division1Percent).HasDefaultValue(0m);
            entity.Property(e => e.Division2Percent).HasDefaultValue(0m);
            entity.Property(e => e.Division3Percent).HasDefaultValue(0m);
            entity.Property(e => e.Division4Percent).HasDefaultValue(0m);
            entity.Property(e => e.Division5Percent).HasDefaultValue(0m);
            entity.Property(e => e.Division6Percent).HasDefaultValue(0m);
        });

        modelBuilder.Entity<ROverheadServiceDivAllocation>(entity =>
        {
            entity.HasKey(e => e.OverheadServiceDivAllocationUid).HasFillFactor(30);

            entity.Property(e => e.OverheadServiceDivAllocationUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RateLogicHdr>(entity =>
        {
            entity.ToTable("RateLogicHdr", tb => tb.HasTrigger("Trg_IsProcessedRateLogicHdr"));

            entity.Property(e => e.RateLogicHdrUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RateLogicItemSubGroupLink>(entity =>
        {
            entity.Property(e => e.RateLogicItemSubGroupLinkUid).ValueGeneratedNever();

            entity.HasOne(d => d.RateLogicHdrU).WithMany(p => p.RateLogicItemSubGroupLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateLogicItemSubGroupLink_RateLogicHdr");
        });

        modelBuilder.Entity<RateLogicMappingAreaItemSubGroup>(entity =>
        {
            entity.Property(e => e.RateLogicMappingAreaItemSubGroupUid).ValueGeneratedNever();

            entity.HasOne(d => d.RateLogicHdrU).WithMany(p => p.RateLogicMappingAreaItemSubGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateLogicMappingAreaItemSubGroup_RateLogicHdr");
        });

        modelBuilder.Entity<RateLogicMappingBranchItemSubGroup>(entity =>
        {
            entity.Property(e => e.RateLogicMappingBranchItemSubGroupUid).ValueGeneratedNever();

            entity.HasOne(d => d.RateLogicHdrU).WithMany(p => p.RateLogicMappingBranchItemSubGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RateLogicMappingBranchItemSubGroup_RateLogicHdr");
        });

        modelBuilder.Entity<RateTypeM>(entity =>
        {
            entity.HasKey(e => e.RateTypeUid).HasFillFactor(80);

            entity.Property(e => e.RateTypeUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RegistrationM>(entity =>
        {
            entity.HasKey(e => e.RegistrationUid).HasFillFactor(80);

            entity.Property(e => e.RegistrationUid).ValueGeneratedNever();

            entity.HasOne(d => d.StateU).WithMany(p => p.RegistrationMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistrationM_StateM");
        });

        modelBuilder.Entity<RejectedInventoryTran>(entity =>
        {
            entity.HasKey(e => e.InventoryTransUid).HasFillFactor(80);

            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsFirstSale).HasDefaultValue(true);
            entity.Property(e => e.SecondarySupplierUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RejectedInventoryTransList>(entity =>
        {
            entity.HasKey(e => e.InventoryTransListUid).HasFillFactor(80);

            entity.HasOne(d => d.InventoryTransU).WithMany(p => p.RejectedInventoryTransLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RejectedInventoryTransList_RejectedInventoryTrans");
        });

        modelBuilder.Entity<RejectedItemDivisionLink>(entity =>
        {
            entity.HasKey(e => new { e.ItemUid, e.DivisionUid }).HasFillFactor(80);

            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ItemU).WithMany(p => p.RejectedItemDivisionLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RejectedItemDivisionLink_RejectedItemM");
        });

        modelBuilder.Entity<RejectedItemDivisionPrincipleLink>(entity =>
        {
            entity.HasKey(e => new { e.ItemUid, e.DivisionPrincipleUid }).HasFillFactor(80);

            entity.Property(e => e.DivisionPrincipleUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ItemU).WithMany(p => p.RejectedItemDivisionPrincipleLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RejectedItemDivisionPrincipleLink_RejectedItemM");
        });

        modelBuilder.Entity<RejectedItemM>(entity =>
        {
            entity.HasKey(e => e.ItemUid).HasFillFactor(80);

            entity.Property(e => e.ItemUid).ValueGeneratedNever();
            entity.Property(e => e.BranchUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ChemicalUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DivisionUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Uomuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RejectedItemRequestPack>(entity =>
        {
            entity.HasKey(e => e.ItemRequestPackUid).HasFillFactor(80);

            entity.Property(e => e.ItemRequestPackUid).ValueGeneratedNever();
            entity.Property(e => e.PackUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ItemU).WithMany(p => p.RejectedItemRequestPacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RejectedItemRequestPack_RejectedItemM");
        });

        modelBuilder.Entity<RejectedPartyM>(entity =>
        {
            entity.Property(e => e.Gstno).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<RejectedPartyShipTo>(entity =>
        {
            entity.Property(e => e.Gstno).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<ReplicationLog>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasFillFactor(80);

            entity.HasIndex(e => new { e.Dbname, e.TableName }, "UK_ReplicationLog")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.Dbname).HasDefaultValue("");
        });

        modelBuilder.Entity<ReplicationLogToBranchFromSync>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReplicationLogToCommonFromSync>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReplicationLogToHo>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasFillFactor(80);

            entity.HasIndex(e => new { e.Dbname, e.TableName }, "UK_ReplicationLogToHo")
                .IsUnique()
                .HasFillFactor(80);
        });

        modelBuilder.Entity<ReplicationLogToSyncFromBranch>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReplicationLogToSyncFromCommon>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ReportAccountCodelink>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasFillFactor(80);

            entity.Property(e => e.ReportId).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestDealerAsset>(entity =>
        {
            entity.HasKey(e => e.DealerAssetUid).HasFillFactor(90);

            entity.Property(e => e.DealerAssetUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestDealerBankDetail>(entity =>
        {
            entity.HasKey(e => e.DealerBankDetailsUid).HasFillFactor(90);

            entity.Property(e => e.DealerBankDetailsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestDealerDeposit>(entity =>
        {
            entity.HasKey(e => e.DealerDepositUid).HasFillFactor(90);

            entity.Property(e => e.DealerDepositUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestItemDivisionLink>(entity =>
        {
            entity.HasKey(e => e.RequestItemDivisionLink1)
                .HasName("PK_requestItemDivisionLink_1")
                .HasFillFactor(90);

            entity.ToTable("RequestItemDivisionLink", tb => tb.HasTrigger("TI_InsertLastNoInItemRequestSlNo_RequestItemDivisionLink"));

            entity.HasIndex(e => new { e.ItemUid, e.DivisionUid }, "IX_RequestItemDivisionLink")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.RequestItemDivisionLink1).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RequestItemM>(entity =>
        {
            entity.HasKey(e => e.ItemUid)
                .HasName("PK_requestItemM")
                .HasFillFactor(90);

            entity.ToTable("RequestItemM", tb => tb.HasTrigger("TI_RejectedRequestItemInsert"));

            entity.Property(e => e.ItemUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestItemRequestPack>(entity =>
        {
            entity.HasKey(e => e.ItemRequestPackUid)
                .HasName("PK_requestItemRequestPack")
                .HasFillFactor(90);

            entity.Property(e => e.ItemRequestPackUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestPartyCreditLimitM>(entity =>
        {
            entity.HasKey(e => e.PartyCreditLimitUid).HasFillFactor(90);

            entity.Property(e => e.PartyCreditLimitUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestPartyM>(entity =>
        {
            entity.HasKey(e => e.PartyUid).HasFillFactor(90);

            entity.Property(e => e.PartyUid).ValueGeneratedNever();
            entity.Property(e => e.Gstno).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<RequestPartyShipTo>(entity =>
        {
            entity.HasKey(e => e.PartyShipToUid).HasFillFactor(90);

            entity.Property(e => e.PartyShipToUid).ValueGeneratedNever();
            entity.Property(e => e.Gstno).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<RequestVoucherDetail>(entity =>
        {
            entity.HasKey(e => e.RequestVoucherDetailUid).HasFillFactor(90);

            entity.Property(e => e.RequestVoucherDetailUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RequestVoucherDetailExtn>(entity =>
        {
            entity.HasKey(e => e.RequestVoucherDetailUid).HasFillFactor(90);

            entity.Property(e => e.RequestVoucherDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RequestVoucherHeader>(entity =>
        {
            entity.HasKey(e => e.RequestVoucherHeaderUid).HasFillFactor(90);

            entity.Property(e => e.RequestVoucherHeaderUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<RequestVoucherHeaderExtn>(entity =>
        {
            entity.HasKey(e => e.RequestVoucherHeaderUid).HasFillFactor(90);

            entity.Property(e => e.RequestVoucherHeaderUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("('')");
            entity.Property(e => e.ModifiedBy).HasDefaultValue("");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<RollingForeCastM>(entity =>
        {
            entity.ToTable("RollingForeCastM", tb => tb.HasTrigger("trg_AfterInsertUpdate_RollingForeCastM"));

            entity.Property(e => e.RollingForeCastMuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<RspItemProfile>(entity =>
        {
            entity.ToView("RSP_Item_Profile");
        });

        modelBuilder.Entity<SalaryPosting>(entity =>
        {
            entity.HasKey(e => e.SalaryPostingUid)
                .HasName("PK_SalaryPosting_1")
                .IsClustered(false)
                .HasFillFactor(30);

            entity.Property(e => e.SalaryPostingUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SalaryandFdposting>(entity =>
        {
            entity.HasKey(e => e.SalaryandFdpostingUid)
                .HasName("PK_SalaryPosting")
                .HasFillFactor(80);

            entity.Property(e => e.SalaryandFdpostingUid).ValueGeneratedNever();
            entity.Property(e => e.BranchCode).IsFixedLength();
            entity.Property(e => e.DrBranchCode).IsFixedLength();
            entity.Property(e => e.VoucherDetailUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VoucherHeaderUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<SalesOfficerM>(entity =>
        {
            entity.HasKey(e => e.Souid).HasFillFactor(90);

            entity.Property(e => e.Souid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<SalesOrderDetail>(entity =>
        {
            entity.Property(e => e.SalesOrderDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SalesOrderForMobile>(entity =>
        {
            entity.HasKey(e => e.SalesOrderUid);  // Manualy Added By DivyabharathiM for testing (BCoz facing PrimaryKey issu )
            entity.Property(e => e.SalesOrderUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SalesOrderFromApp>(entity =>
        {
            entity.Property(e => e.SalesOrderNoUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SalesOrderHdr>(entity =>
        {
            entity.Property(e => e.SalesOrderHdrUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Schedule6GroupM>(entity =>
        {
            entity.HasKey(e => e.Schedule6GroupUid).HasFillFactor(80);

            entity.Property(e => e.Schedule6GroupUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ScheduleTypeM>(entity =>
        {
            entity.HasKey(e => e.ScheduleTypeUid)
                .HasName("PK_ScheduleType")
                .HasFillFactor(80);

            entity.Property(e => e.ScheduleTypeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SchemeCnbranchRequest>(entity =>
        {
            entity.HasKey(e => e.SchemeCnrequestUid).HasFillFactor(80);

            entity.Property(e => e.SchemeCnrequestUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SchemeCreditNoteApprovalDoc>(entity =>
        {
            entity.HasKey(e => e.SchemeCreditNoteApprovalDocUid).HasFillFactor(90);

            entity.Property(e => e.SchemeCreditNoteApprovalDocUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SchemeGeneration>(entity =>
        {
            entity.HasKey(e => e.SchemeGenerationUid).HasFillFactor(80);

            entity.Property(e => e.SchemeGenerationUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.SchemeGenerations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchemeGeneration_BranchM");

            entity.HasOne(d => d.DiscountU).WithMany(p => p.SchemeGenerations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchemeGeneration_DiscountM");

            entity.HasOne(d => d.DivisionU).WithMany(p => p.SchemeGenerations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchemeGeneration_DivisionM");
        });

        modelBuilder.Entity<SecSupplierCodeSlno>(entity =>
        {
            entity.HasKey(e => new { e.StateUid, e.Letter }).HasFillFactor(80);
        });

        modelBuilder.Entity<SecondarySupplierM>(entity =>
        {
            entity.HasKey(e => e.SecondarySupplierUid).HasFillFactor(80);

            entity.ToTable("SecondarySupplierM", tb => tb.HasTrigger("TI_CodeSlNo"));

            entity.Property(e => e.SecondarySupplierUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Gstno).HasDefaultValueSql("((0))");
            entity.Property(e => e.Tinno).HasDefaultValue("");

            entity.HasOne(d => d.CountryU).WithMany(p => p.SecondarySupplierMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SecondarySupplierM_CountryM");

            entity.HasOne(d => d.StateU).WithMany(p => p.SecondarySupplierMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SecondarySupplierM_StateM");
        });

        modelBuilder.Entity<SeedCategoryM>(entity =>
        {
            entity.HasKey(e => e.SeedCategoryUid).HasFillFactor(80);

            entity.Property(e => e.SeedCategoryUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SeedGovtDetail>(entity =>
        {
            entity.HasKey(e => e.SeedGovtDetailUid).HasFillFactor(80);

            entity.Property(e => e.SeedGovtDetailUid).ValueGeneratedNever();

            entity.HasOne(d => d.ReceiptInventoryTransU).WithMany(p => p.SeedGovtDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeedGovtDetail_InventoryTrans");
        });

        modelBuilder.Entity<SeedTypeM>(entity =>
        {
            entity.HasKey(e => e.SeedTypeUid).HasFillFactor(80);

            entity.Property(e => e.SeedTypeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SeedVarietyM>(entity =>
        {
            entity.HasKey(e => e.SeedVarietyUid).HasFillFactor(90);

            entity.Property(e => e.SeedVarietyUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SelectMonthName>(entity =>
        {
            entity.ToView("SelectMonthName");
        });

        modelBuilder.Entity<ServerDateTimeValidation>(entity =>
        {
            entity.Property(e => e.ServerLastSyncDate).HasDefaultValue(new DateTime(2010, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        });

        modelBuilder.Entity<SingleInvoiceTradeDiscountExemptedM>(entity =>
        {
            entity.HasKey(e => e.SingleInvoiceTradeDiscountExpUid).HasFillFactor(30);

            entity.HasIndex(e => new { e.PartyUid, e.DiscountUid }, "UK_SingleInvoiceTradeDiscountExemptedM")
                .IsUnique()
                .HasFillFactor(30);

            entity.Property(e => e.SingleInvoiceTradeDiscountExpUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Soamendment>(entity =>
        {
            entity.HasKey(e => e.SoamendmentUid)
                .HasName("PK_SOAmmendments")
                .HasFillFactor(80);

            entity.Property(e => e.SoamendmentUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Sodetail>(entity =>
        {
            entity.HasKey(e => e.SodetailUid).HasFillFactor(80);

            entity.Property(e => e.SodetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SoforwardBranch>(entity =>
        {
            entity.HasKey(e => e.SoforwardBranchUid).HasFillFactor(80);

            entity.ToTable("SOForwardBranch", tb => tb.HasTrigger("TI_SoForwardBranchUID"));

            entity.Property(e => e.SoforwardBranchUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Soheader>(entity =>
        {
            entity.HasKey(e => e.SoheaderUid).HasFillFactor(90);

            entity.ToTable("SOHeader", tb =>
                {
                    tb.HasTrigger("TI_SODocumentNo");
                    tb.HasTrigger("TI_SOHeaderUID");
                });
        });

        modelBuilder.Entity<SoheaderHoapproved>(entity =>
        {
            entity.HasKey(e => e.SoheaderUid).HasFillFactor(90);

            entity.ToTable("SOHeaderHOApproved", tb => tb.HasTrigger("TU_InsertSOAmendment"));
        });

        modelBuilder.Entity<SowingReportM>(entity =>
        {
            entity.Property(e => e.SowingReportUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<StDecl>(entity =>
        {
            entity.Property(e => e.Decl).IsFixedLength();
            entity.Property(e => e.Stcod).IsFixedLength();
        });

        modelBuilder.Entity<StanesSsisjob>(entity =>
        {
            entity.HasIndex(e => e.JobId, "UQ_Job_Id")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BranchCode).IsFixedLength();
        });

        modelBuilder.Entity<StateCommodityM>(entity =>
        {
            entity.HasKey(e => e.StateCommodityUid).HasFillFactor(80);

            entity.Property(e => e.StateCommodityUid).ValueGeneratedNever();
            entity.Property(e => e.CommodityUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CommodityU).WithMany(p => p.StateCommodityMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StateCommodityM_CommodityCodeM");

            entity.HasOne(d => d.StateU).WithMany(p => p.StateCommodityMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StateCommodityM_StateM");
        });

        modelBuilder.Entity<StateDistrictMappingM>(entity =>
        {
            entity.Property(e => e.StateDistrictMappingUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<StateItemRate>(entity =>
        {
            entity.HasKey(e => e.StateItemRateUid).HasFillFactor(90);

            entity.ToTable("StateItemRate", tb => tb.HasTrigger("TI_DeletedStateItemRate"));

            entity.Property(e => e.StateItemRateUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemRateHeaderU).WithMany(p => p.StateItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StateItemRate_ItemRateHeader");

            entity.HasOne(d => d.StateU).WithMany(p => p.StateItemRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StateItemRate_StateM");
        });

        modelBuilder.Entity<StateM>(entity =>
        {
            entity.ToView("State_M");
        });

        modelBuilder.Entity<StateM1>(entity =>
        {
            entity.HasKey(e => e.StateUid).HasFillFactor(80);

            entity.Property(e => e.StateUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<StateMf>(entity =>
        {
            entity.ToView("StateMF");
        });

        modelBuilder.Entity<StatusM>(entity =>
        {
            entity.HasKey(e => e.StatusUid).HasFillFactor(80);

            entity.Property(e => e.StatusUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<StockPointCommisionAccountMapping>(entity =>
        {
            entity.HasKey(e => e.StockPointCommisionAccountMappingUid).HasFillFactor(80);

            entity.Property(e => e.StockPointCommisionAccountMappingUid).ValueGeneratedNever();

            entity.HasOne(d => d.AccountU).WithMany(p => p.StockPointCommisionAccountMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointCommisionAccountMapping_AccountM");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.StockPointCommisionAccountMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointCommisionAccountMapping_DivisionPrincipleM");
        });

        modelBuilder.Entity<StockPointCommisionInventoryLink>(entity =>
        {
            entity.HasKey(e => e.SpclinkUid).HasFillFactor(30);

            entity.Property(e => e.SpclinkUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<StockPointCommisionM>(entity =>
        {
            entity.HasKey(e => e.StockPointCommisionUid).HasFillFactor(80);

            entity.Property(e => e.StockPointCommisionUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.StockPointCommisionMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointCommisionM_BranchM");
        });

        modelBuilder.Entity<StockPointCommissionDetail>(entity =>
        {
            entity.HasKey(e => e.StockPointCommissionDetailUid).HasFillFactor(80);

            entity.Property(e => e.StockPointCommissionDetailUid).ValueGeneratedNever();

            entity.HasOne(d => d.AccountU).WithMany(p => p.StockPointCommissionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointCommissionDetail_AccountM");

            entity.HasOne(d => d.DivisionPrincipleU).WithMany(p => p.StockPointCommissionDetails).HasConstraintName("FK_StockPointCommissionDetail_DivisionPrincipleM");

            entity.HasOne(d => d.StockPointCommisionU).WithMany(p => p.StockPointCommissionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointCommissionDetail_StockPointCommisionM");
        });

        modelBuilder.Entity<StockPointCommissionDetailNew>(entity =>
        {
            entity.HasKey(e => e.StockPointCommissionDetailUid).HasFillFactor(90);

            entity.HasIndex(e => new { e.StockPointCommissionUid, e.ItemUid, e.IsActive }, "UK_StockPointCommissionDetail_New")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.StockPointCommissionDetailUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemU).WithMany(p => p.StockPointCommissionDetailNews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ItemUID");

            entity.HasOne(d => d.StockPointCommissionU).WithMany(p => p.StockPointCommissionDetailNews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointCommissionUID");
        });

        modelBuilder.Entity<StockPointCommissionMNew>(entity =>
        {
            entity.HasKey(e => e.StockPointCommissionUid).HasFillFactor(90);

            entity.HasIndex(e => new { e.StockPointCommissionDesc, e.IsActive }, "UK_StockPointCommissionM_New")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.StockPointCommissionUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<StockPointDealerMapping>(entity =>
        {
            entity.HasKey(e => e.StockPointDealermappingUid).HasFillFactor(80);

            entity.Property(e => e.StockPointDealermappingUid).ValueGeneratedNever();

            entity.HasOne(d => d.BranchU).WithMany(p => p.StockPointDealerMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointDealerMapping_BranchM");

            entity.HasOne(d => d.PartyU).WithMany(p => p.StockPointDealerMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPointDealerMapping_PartyM");
        });

        modelBuilder.Entity<StockSnoM>(entity =>
        {
            entity.HasKey(e => e.StockSnouid).HasFillFactor(90);

            entity.HasIndex(e => new { e.BranchUid, e.InvTransactionTypeUid, e.StockSnocode }, "IX_StockSnoM")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.StockSnouid).ValueGeneratedNever();
        });

        modelBuilder.Entity<StockTransferReceiptRemovalLink>(entity =>
        {
            entity.HasKey(e => e.StockTransferReceiptRemovalLinkUid)
                .HasName("PK_BranchTransferReceiptLink")
                .HasFillFactor(30);

            entity.Property(e => e.StockTransferReceiptRemovalLinkUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<StorageLocationM>(entity =>
        {
            entity.Property(e => e.LocationUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<SupVoucherMatch>(entity =>
        {
            entity.HasKey(e => e.SupVoucherMatchUid).HasFillFactor(80);

            entity.Property(e => e.SupVoucherMatchUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SupplierCodeSlNo>(entity =>
        {
            entity.Property(e => e.Letter).IsFixedLength();
        });

        modelBuilder.Entity<SupplierControlCodeM>(entity =>
        {
            entity.HasKey(e => e.SupplierControlCodeUid).HasFillFactor(80);

            entity.Property(e => e.SupplierControlCodeUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.PartyType).IsFixedLength();
        });

        modelBuilder.Entity<SupplierDeliveryMode>(entity =>
        {
            entity.Property(e => e.DeliveryModeUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<SurveyBasalFertilizer>(entity =>
        {
            entity.Property(e => e.SurveyBasalFertilizerUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SurveyMicroNutrient>(entity =>
        {
            entity.Property(e => e.SurveyMicroNutrientsUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SurveyPesticide>(entity =>
        {
            entity.Property(e => e.SurveyPesticidesUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SurveyQuestionnare>(entity =>
        {
            entity.Property(e => e.SurveyQuestionnareUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SurveyTopDressing>(entity =>
        {
            entity.Property(e => e.SurveyTopDressingUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SyncDblist>(entity =>
        {
            entity.HasKey(e => e.SyncDblistUid).HasFillFactor(80);

            entity.HasIndex(e => e.SyncDbname, "UK_SyncDBList")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.SyncDblistUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SyncStatus>(entity =>
        {
            entity.HasKey(e => e.SyncUid).HasFillFactor(80);

            entity.Property(e => e.SyncUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SyncTableList>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasFillFactor(80);

            entity.HasIndex(e => new { e.GroupNo, e.OrderNo }, "IX_SyncTableList")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.TableName, "UK_SyncTableList")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<SyncTableListToHo>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasFillFactor(80);

            entity.HasIndex(e => new { e.GroupNo, e.OrderNo }, "IX_SyncTableListToHo")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.TableName, "UK_SyncTableListToHo")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<SynchronizObject>(entity =>
        {
            entity.HasKey(e => e.SyncObjectUid).HasFillFactor(80);

            entity.Property(e => e.SyncObjectUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TabillApproval>(entity =>
        {
            entity.HasKey(e => e.TabillUid).HasFillFactor(30);

            entity.Property(e => e.TabillUid).ValueGeneratedNever();
            entity.Property(e => e.Isactive).IsFixedLength();
        });

        modelBuilder.Entity<TabillDeduction>(entity =>
        {
            entity.HasKey(e => e.TabillDeductionUid).HasFillFactor(30);

            entity.Property(e => e.TabillDeductionUid).ValueGeneratedNever();
            entity.Property(e => e.Isactive).IsFixedLength();
        });

        modelBuilder.Entity<TabillManualReceived>(entity =>
        {
            entity.HasKey(e => e.TabillUid).HasFillFactor(30);

            entity.Property(e => e.TabillUid).ValueGeneratedNever();
            entity.Property(e => e.Isactive).IsFixedLength();
        });

        modelBuilder.Entity<TabillRequest>(entity =>
        {
            entity.HasKey(e => e.TabillUid).HasFillFactor(90);

            entity.Property(e => e.TabillUid).ValueGeneratedNever();
            entity.Property(e => e.Isactive).IsFixedLength();
        });

        modelBuilder.Entity<TaempSubM>(entity =>
        {
            entity.Property(e => e.EmployeeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TaemployeeM>(entity =>
        {
            entity.HasKey(e => e.EmployeeUid).HasFillFactor(30);

            entity.Property(e => e.EmployeeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TargetFixM>(entity =>
        {
            entity.Property(e => e.TargetFixMuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TargetM>(entity =>
        {
            entity.Property(e => e.TargetUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TaxExemptedItemMaster>(entity =>
        {
            entity.HasKey(e => e.TaxExemptedItemMasterUid).HasFillFactor(80);

            entity.Property(e => e.TaxExemptedItemMasterUid).ValueGeneratedNever();

            entity.HasOne(d => d.ItemSubGroupU).WithMany(p => p.TaxExemptedItemMasters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxExemptedItemMaster_ItemSubGroupM");
        });

        modelBuilder.Entity<TaxM>(entity =>
        {
            entity.HasKey(e => e.TaxUid).HasFillFactor(90);

            entity.ToTable("TaxM", tb => tb.HasTrigger("Trg_IsSendtoBranchTax"));

            entity.HasIndex(e => new { e.DivisionUid, e.ItemGroupUid, e.StateUid, e.ItemSubGroupUid, e.FirstSales, e.ItemUid, e.EffectiveFrom }, "UK_TaxM")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.TaxUid).ValueGeneratedNever();

            entity.HasOne(d => d.DivisionU).WithMany(p => p.TaxMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxM_DivisionM");

            entity.HasOne(d => d.ItemGroupU).WithMany(p => p.TaxMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxM_ItemGroupM");

            entity.HasOne(d => d.ItemSubGroupU).WithMany(p => p.TaxMs).HasConstraintName("FK_TaxM_ItemSubGroupM");

            entity.HasOne(d => d.ItemU).WithMany(p => p.TaxMs).HasConstraintName("FK_TaxM_ItemM");

            entity.HasOne(d => d.StateU).WithMany(p => p.TaxMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxM_StateM");
        });

        modelBuilder.Entity<TaxMdetail>(entity =>
        {
            entity.HasKey(e => e.TaxDetailsUid).HasFillFactor(90);

            entity.Property(e => e.TaxDetailsUid).ValueGeneratedNever();

            entity.HasOne(d => d.TaxTypeU).WithMany(p => p.TaxMdetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxMDetails_TaxTypeM");

            entity.HasOne(d => d.TaxU).WithMany(p => p.TaxMdetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaxMDetails_TaxM");
        });

        modelBuilder.Entity<TaxTypeM>(entity =>
        {
            entity.HasKey(e => e.TaxTypeUid).HasFillFactor(80);

            entity.HasIndex(e => e.TaxTypeCode, "IX_TaxTypeCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.TaxTypeUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<TrailBalance>(entity =>
        {
            entity.ToView("TrailBalance");
        });

        modelBuilder.Entity<TransactionSlNo>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_TransactionSlNos"));
        });

        modelBuilder.Entity<TransactionTypeConfiguration>(entity =>
        {
            entity.HasKey(e => e.TransactionTypeConfigurationUid).HasFillFactor(90);

            entity.Property(e => e.TransactionTypeConfigurationUid).ValueGeneratedNever();

            entity.HasOne(d => d.TransactionTypeU).WithMany(p => p.TransactionTypeConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionTypeConfiguration_TransactionTypesM");
        });

        modelBuilder.Entity<TransactionTypePurposeDetailM>(entity =>
        {
            entity.HasKey(e => e.TransactionTypePurposeTranUid).HasFillFactor(90);

            entity.Property(e => e.TransactionTypePurposeTranUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TransactionTypePurposeUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TransactionTypePurposeU).WithMany(p => p.TransactionTypePurposeDetailMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionTypePurposeDetailM_TransactionTypePurposeHeaderM");
        });

        modelBuilder.Entity<TransactionTypePurposeHeaderM>(entity =>
        {
            entity.HasKey(e => e.TransactionTypePurposeUid).HasFillFactor(80);

            entity.Property(e => e.TransactionTypePurposeUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TransactiontypesU).WithMany(p => p.TransactionTypePurposeHeaderMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionTypePurposeHeaderM_TransactionTypesM");
        });

        modelBuilder.Entity<TransactionTypePurposeLinkM>(entity =>
        {
            entity.HasKey(e => e.TransactionTypePurposeLinkUid).HasFillFactor(30);

            entity.Property(e => e.TransactionTypePurposeLinkUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TransactionTypesM>(entity =>
        {
            entity.HasKey(e => e.TransactiontypesUid).HasFillFactor(80);

            entity.HasIndex(e => e.TransactionTypeCode, "IX_TransactionTypesCode")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.TransactiontypesUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ttcbranch>(entity =>
        {
            entity.HasKey(e => e.TtcbranchUid).HasFillFactor(80);

            entity.Property(e => e.TtcbranchUid).ValueGeneratedNever();

            entity.HasOne(d => d.TransactionTypeConfigurationU).WithMany(p => p.Ttcbranches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTCBranch_TransactionTypeConfiguration");
        });

        modelBuilder.Entity<Ttccategory>(entity =>
        {
            entity.HasKey(e => e.TtccategoryUid).HasFillFactor(90);

            entity.Property(e => e.TtccategoryUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ttccheck>(entity =>
        {
            entity.ToView("TTCCheck");
        });

        modelBuilder.Entity<Ttcdivision>(entity =>
        {
            entity.HasKey(e => e.TtcdivisionUid).HasFillFactor(90);

            entity.Property(e => e.TtcdivisionUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Ttcstate>(entity =>
        {
            entity.HasKey(e => e.TtcstateUid).HasFillFactor(80);

            entity.Property(e => e.TtcstateUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TtcsubGroup>(entity =>
        {
            entity.HasKey(e => e.TtcsubGroupUid).HasFillFactor(80);

            entity.Property(e => e.TtcsubGroupUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TyreRetreadingAttendedByM>(entity =>
        {
            entity.HasKey(e => e.TyreRetreadingAttendedByUid).HasFillFactor(80);

            entity.Property(e => e.TyreRetreadingAttendedByUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UnAdjustedCredit>(entity =>
        {
            entity.ToView("UnAdjustedCredits");
        });

        modelBuilder.Entity<UnAdjustedDebit>(entity =>
        {
            entity.ToView("UnAdjustedDebits");
        });

        modelBuilder.Entity<Uomm>(entity =>
        {
            entity.HasKey(e => e.Uomuid).HasFillFactor(80);

            entity.Property(e => e.Uomuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserUid).HasFillFactor(90);

            entity.HasIndex(e => e.UserCode, "IX_Users")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UserUid).ValueGeneratedNever();
            entity.Property(e => e.Email).HasDefaultValue("");
            entity.Property(e => e.LastLoginDate).HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            entity.Property(e => e.TelephoneNo).HasDefaultValue("");

            entity.HasOne(d => d.UserGroupU).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_UserGroupM");
        });

        modelBuilder.Entity<UserBranchMapping>(entity =>
        {
            entity.HasKey(e => e.UserBranchMappingUid)
                .HasName("PK_UserBranchMapping_1")
                .HasFillFactor(90);

            entity.Property(e => e.UserBranchMappingUid).ValueGeneratedNever();
            entity.Property(e => e.UserUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.UserU).WithMany(p => p.UserBranchMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserBranchMapping_Users");
        });

        modelBuilder.Entity<UserGroupDivisionMappingM>(entity =>
        {
            entity.HasKey(e => e.UserGroupDivisionMappingUid).HasFillFactor(90);

            entity.Property(e => e.UserGroupDivisionMappingUid).ValueGeneratedNever();

            entity.HasOne(d => d.DivisionU).WithMany(p => p.UserGroupDivisionMappingMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroupDivisionMappingM_DivisionM");

            entity.HasOne(d => d.UserGroupU).WithMany(p => p.UserGroupDivisionMappingMs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserGroupDivisionMappingM_UserGroupM");
        });

        modelBuilder.Entity<UserGroupM>(entity =>
        {
            entity.HasKey(e => e.UserGroupUid)
                .HasName("PK_UserGroup")
                .HasFillFactor(80);

            entity.Property(e => e.UserGroupUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserRight>(entity =>
        {
            entity.HasKey(e => e.UserRightsUid)
                .HasName("PK_UserRights_1")
                .HasFillFactor(80);

            entity.HasIndex(e => new { e.UserUid, e.MenuUid }, "IX_UserRights")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.UserRightsUid).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MAdd).HasDefaultValue(true);
            entity.Property(e => e.MDelete).HasDefaultValue(true);
            entity.Property(e => e.MEdit).HasDefaultValue(true);
            entity.Property(e => e.OfAdd).HasDefaultValue(true);
            entity.Property(e => e.OfDelete).HasDefaultValue(true);
            entity.Property(e => e.OfEdit).HasDefaultValue(true);

            entity.HasOne(d => d.MenuU).WithMany(p => p.UserRights)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRights_MenusM");
        });

        modelBuilder.Entity<UserTypeLink>(entity =>
        {
            entity.HasKey(e => e.UserUid).HasFillFactor(90);

            entity.Property(e => e.UserUid).ValueGeneratedNever();

            entity.HasOne(d => d.UserU).WithOne(p => p.UserTypeLink)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTypeLink_Users");
        });

        modelBuilder.Entity<UserTypeM>(entity =>
        {
            entity.HasKey(e => e.UserTypeUid).HasFillFactor(80);

            entity.Property(e => e.UserTypeUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VatnotConsideredGroup>(entity =>
        {
            entity.HasKey(e => e.ItemGroupUid).HasFillFactor(80);

            entity.Property(e => e.ItemGroupUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VechicleM>(entity =>
        {
            entity.HasKey(e => e.VechicleUid).HasFillFactor(90);

            entity.Property(e => e.VechicleUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VechicleTran>(entity =>
        {
            entity.HasKey(e => e.VechicleTranUid).HasFillFactor(90);

            entity.Property(e => e.VechicleTranUid).ValueGeneratedNever();

            entity.HasOne(d => d.VechicleU).WithMany(p => p.VechicleTrans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VechicleTran_VechicleM");
        });

        modelBuilder.Entity<VehicleReimbursementDetail>(entity =>
        {
            entity.Property(e => e.VehicleReimbursementDetailsUid).ValueGeneratedNever();

            entity.HasOne(d => d.VehicleReimbursementU).WithMany(p => p.VehicleReimbursementDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VehicleReimbursementDetails_VehicleReimbursementM");
        });

        modelBuilder.Entity<VehicleReimbursementM>(entity =>
        {
            entity.Property(e => e.VehicleReimbursementUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VendorMappingM>(entity =>
        {
            entity.HasKey(e => e.VendorMappingUid).HasFillFactor(80);

            entity.HasIndex(e => e.SupplierUid, "UK_VendorMappingM")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.CustomerUid, "UK_VendorMappingMCustomer")
                .IsUnique()
                .HasFillFactor(80);

            entity.Property(e => e.VendorMappingUid).ValueGeneratedNever();

            entity.HasOne(d => d.CustomerU).WithOne(p => p.VendorMappingMCustomerU)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VendorMappingM_PartyM");

            entity.HasOne(d => d.SupplierU).WithOne(p => p.VendorMappingMSupplierU).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VerficationCodeM>(entity =>
        {
            entity.HasKey(e => e.VerificationCodeMuid).HasFillFactor(80);

            entity.Property(e => e.VerificationCodeMuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<VersionM>(entity =>
        {
            entity.ToTable("VersionM", tb => tb.HasTrigger("TU_VersionM"));

            entity.Property(e => e.VersionId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity.ToView("View_1");
        });

        modelBuilder.Entity<VoucherDetail>(entity =>
        {
            entity.HasKey(e => e.VoucherDetailUid).HasFillFactor(90);

            entity.ToTable("VoucherDetail", tb =>
                {
                    tb.HasTrigger("AccountGroupCheck");
                    tb.HasTrigger("BrMgrBankDebitUpdate");
                    tb.HasTrigger("IBTUpdate");
                    tb.HasTrigger("TI_VoucherDetail_VoucherMatch");
                });

            entity.Property(e => e.VoucherDetailUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AccountU).WithMany(p => p.VoucherDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherDetail_AccountM");

            entity.HasOne(d => d.VoucherHeaderU).WithMany(p => p.VoucherDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherDetail_VoucherHeader");
        });

        modelBuilder.Entity<VoucherDetailExtn>(entity =>
        {
            entity.HasKey(e => e.VoucherDetailUid).HasFillFactor(90);

            entity.Property(e => e.VoucherDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VoucherDetailFreightExtn>(entity =>
        {
            entity.HasKey(e => e.VoucherDetailUid).HasFillFactor(90);

            entity.Property(e => e.VoucherDetailUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VoucherDetailToBranch>(entity =>
        {
            entity.HasKey(e => e.VoucherDetailUid).HasFillFactor(80);

            entity.Property(e => e.VoucherDetailUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<VoucherHeader>(entity =>
        {
            entity.HasKey(e => e.VoucherHeaderUid).HasFillFactor(90);

            entity.ToTable("VoucherHeader", tb =>
                {
                    tb.HasTrigger("BrMgrBankDebitUpdate_Header");
                    tb.HasTrigger("TI_IBTUpdate_VoucherHeader");
                    tb.HasTrigger("TI_Validate_VoucherHeader_VoucherNo");
                    tb.HasTrigger("TI_VoucherHeader_VoucherMatch");
                    tb.HasTrigger("TU_PayMentApprovals");
                });

            entity.Property(e => e.VoucherHeaderUid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.PayModeU).WithMany(p => p.VoucherHeaders).HasConstraintName("FK_VoucherHeader_PayModeM");

            entity.HasOne(d => d.TransactionTypePurposeTranU).WithMany(p => p.VoucherHeaders).HasConstraintName("FK_VoucherHeader_TransactionTypePurposeDetailM");
        });

        modelBuilder.Entity<VoucherHeaderExtn>(entity =>
        {
            entity.HasKey(e => e.VoucherHeaderUid).HasFillFactor(90);

            entity.Property(e => e.VoucherHeaderUid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("('')");
            entity.Property(e => e.ModifiedBy).HasDefaultValue("");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<VoucherHoapproved>(entity =>
        {
            entity.HasKey(e => e.VoucherHoapprovedUid).HasFillFactor(80);

            entity.Property(e => e.VoucherHoapprovedUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VoucherHotoApprove>(entity =>
        {
            entity.HasKey(e => e.VoucherHotoApproveUid).HasFillFactor(80);

            entity.Property(e => e.VoucherHotoApproveUid).ValueGeneratedNever();
        });

        modelBuilder.Entity<VoucherMatch>(entity =>
        {
            entity.HasKey(e => e.VoucherMatchUid).HasFillFactor(90);

            entity.Property(e => e.VoucherMatchUid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<VoucherMatchLink>(entity =>
        {
            entity.HasKey(e => e.VoucherMatchLinkUid).HasFillFactor(90);

            entity.ToTable("VoucherMatchLink", tb =>
                {
                    tb.HasTrigger("InsertIntoChequeBounceHistory");
                    tb.HasTrigger("TI_VoucherMatchAdjAmountCheck");
                });

            entity.Property(e => e.VoucherMatchLinkUid).ValueGeneratedNever();

            entity.HasOne(d => d.VoucherMatchCru).WithMany(p => p.VoucherMatchLinkVoucherMatchCrus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherMatchLink_VoucherMatch1");

            entity.HasOne(d => d.VoucherMatchDru).WithMany(p => p.VoucherMatchLinkVoucherMatchDrus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherMatchLink_VoucherMatch");
        });

        modelBuilder.Entity<VoucherSchemeDetail>(entity =>
        {
            entity.HasKey(e => e.VoucherSchemeDetailsUid).HasFillFactor(80);

            entity.Property(e => e.VoucherSchemeDetailsUid).ValueGeneratedNever();

            entity.HasOne(d => d.InventoryTransListU).WithMany(p => p.VoucherSchemeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherSchemeDetails_InventoryTransList");

            entity.HasOne(d => d.VoucherHeaderU).WithMany(p => p.VoucherSchemeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VoucherSchemeDetails_VoucherHeader");
        });

        modelBuilder.Entity<VwApprovedVoucher>(entity =>
        {
            entity.ToView("VW_ApprovedVoucher");
        });

        modelBuilder.Entity<VwAwaitingHoapproval>(entity =>
        {
            entity.ToView("Vw_AwaitingHOApproval");
        });

        modelBuilder.Entity<VwBatch>(entity =>
        {
            entity.ToView("Vw_Batch");
        });

        modelBuilder.Entity<VwBatchdetail>(entity =>
        {
            entity.ToView("VW_Batchdetails");
        });

        modelBuilder.Entity<VwBceSum1>(entity =>
        {
            entity.ToView("vw_bce_sum1");
        });

        modelBuilder.Entity<VwChequeLodgementDetail>(entity =>
        {
            entity.ToView("VW_ChequeLodgementDetails");
        });

        modelBuilder.Entity<VwChqDebitDet>(entity =>
        {
            entity.ToView("vw_chq_debit_det");
        });

        modelBuilder.Entity<VwChqRealDet>(entity =>
        {
            entity.ToView("VW_CHQ_REAL_DET");
        });

        modelBuilder.Entity<VwChqbCr>(entity =>
        {
            entity.ToView("vw_chqb_cr");
        });

        modelBuilder.Entity<VwClosingStock>(entity =>
        {
            entity.ToView("Vw_ClosingStock");
        });

        modelBuilder.Entity<VwCommodityMaster>(entity =>
        {
            entity.ToView("Vw_CommodityMaster");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyClosingstock>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyClosingstock");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyGit>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyGIT");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyJournal>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyJournal");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyLedger>(entity =>
        {
            entity.ToView("Vw_ConsolidatedMonthlyLedger");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyOutstandingPayable>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyOutstandingPayables");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyOutstandingReceivable>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyOutstandingReceivables");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyPurchaseProvision>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyPurchaseProvision");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyPurchaseReturnSettlement>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyPurchaseReturnSettlement");
        });

        modelBuilder.Entity<VwConsolidatedMonthlySalesBook>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlySalesBook");
        });

        modelBuilder.Entity<VwConsolidatedMonthlyTaxProvision>(entity =>
        {
            entity.ToView("VW_ConsolidatedMonthlyTaxProvision");
        });

        modelBuilder.Entity<VwConsolidatedPartywiseMonthlySalesBook>(entity =>
        {
            entity.ToView("VW_ConsolidatedPartywiseMonthlySalesBook");
        });

        modelBuilder.Entity<VwConsolidatedPartywiseMonthlySalesReturnBook>(entity =>
        {
            entity.ToView("VW_ConsolidatedPartywiseMonthlySalesReturnBook");
        });

        modelBuilder.Entity<VwCreditOutStanding>(entity =>
        {
            entity.ToView("VW_CreditOutStanding");
        });

        modelBuilder.Entity<VwCreditnoteFinal>(entity =>
        {
            entity.ToView("VW_CREDITNOTE_FINAL");
        });

        modelBuilder.Entity<VwCrlimitDivisionprinciple>(entity =>
        {
            entity.ToView("Vw_crlimitDivisionprinciple");
        });

        modelBuilder.Entity<VwCrlmt>(entity =>
        {
            entity.ToView("vw_crlmt");
        });

        modelBuilder.Entity<VwDebitOutStanding>(entity =>
        {
            entity.ToView("VW_DebitOutStanding");
        });

        modelBuilder.Entity<VwDebitnoteFinal>(entity =>
        {
            entity.ToView("VW_DEBITNOTE_FINAL");
        });

        modelBuilder.Entity<VwDespdetail>(entity =>
        {
            entity.ToView("vw_despdetails");
        });

        modelBuilder.Entity<VwDetailsOfStockTransferIssue>(entity =>
        {
            entity.ToView("VW_DetailsOfStockTransferIssue");
        });

        modelBuilder.Entity<VwDetailsOfStockTransferReceived>(entity =>
        {
            entity.ToView("VW_DetailsOfStockTransferReceived");
        });

        modelBuilder.Entity<VwDetailsofPurchaseReturn>(entity =>
        {
            entity.ToView("VW_DetailsofPurchaseReturn");
        });

        modelBuilder.Entity<VwDetailsofPurchaseUpLoad>(entity =>
        {
            entity.ToView("VW_DetailsofPurchaseUpLoad");
        });

        modelBuilder.Entity<VwDetailsofSalesReturn>(entity =>
        {
            entity.ToView("VW_DetailsofSalesReturn");
        });

        modelBuilder.Entity<VwDetailsofSalesUpLoad>(entity =>
        {
            entity.ToView("VW_DetailsofSalesUpLoad");
        });

        modelBuilder.Entity<VwDiscountItemDetail>(entity =>
        {
            entity.ToView("VW_DiscountItemDetails");
        });

        modelBuilder.Entity<VwDlyCashComb>(entity =>
        {
            entity.ToView("vw_dly_cash_comb");
        });

        modelBuilder.Entity<VwEdsReceipt>(entity =>
        {
            entity.ToView("VW_EdsReceipts");
        });

        modelBuilder.Entity<VwEdsTransaction>(entity =>
        {
            entity.ToView("VW_EdsTransaction");
        });

        modelBuilder.Entity<VwFicsal>(entity =>
        {
            entity.ToView("Vw_Ficsal");
        });

        modelBuilder.Entity<VwFicsalFinal>(entity =>
        {
            entity.ToView("Vw_FicsalFinal");
        });

        modelBuilder.Entity<VwFinancialYearM>(entity =>
        {
            entity.ToView("Vw_FinancialYearM");
        });

        modelBuilder.Entity<VwInvFinal>(entity =>
        {
            entity.ToView("VW_INV_FINAL");

            entity.Property(e => e.Decl).IsFixedLength();
            entity.Property(e => e.Desc).IsFixedLength();
        });

        modelBuilder.Entity<VwInvHead>(entity =>
        {
            entity.ToView("vw_inv_head");
        });

        modelBuilder.Entity<VwInvList>(entity =>
        {
            entity.ToView("vw_inv_list");
        });

        modelBuilder.Entity<VwInventory>(entity =>
        {
            entity.ToView("Vw_Inventory");
        });

        modelBuilder.Entity<VwInventoryService>(entity =>
        {
            entity.ToView("Vw_InventoryService");
        });

        modelBuilder.Entity<VwInventoryServiceTran>(entity =>
        {
            entity.ToView("Vw_InventoryServiceTrans");
        });

        modelBuilder.Entity<VwInventoryServiceTransList>(entity =>
        {
            entity.ToView("VW_InventoryServiceTransList");
        });

        modelBuilder.Entity<VwInventorytran>(entity =>
        {
            entity.ToView("VW_Inventorytrans");
        });

        modelBuilder.Entity<VwInventorytranslist>(entity =>
        {
            entity.ToView("VW_Inventorytranslist");
        });

        modelBuilder.Entity<VwItemDvnnam>(entity =>
        {
            entity.ToView("VW_ITEM_DVNNAM");
        });

        modelBuilder.Entity<VwItemM>(entity =>
        {
            entity.ToView("VW_ItemM");
        });

        modelBuilder.Entity<VwItemRate>(entity =>
        {
            entity.ToView("Vw_ItemRate");
        });

        modelBuilder.Entity<VwItemRateHeader>(entity =>
        {
            entity.ToView("VW_ItemRateHeader");
        });

        modelBuilder.Entity<VwItemReOrderLevel>(entity =>
        {
            entity.ToView("Vw_ItemReOrderLevel");
        });

        modelBuilder.Entity<VwItemSeedM>(entity =>
        {
            entity.ToView("VW_ItemSeedM");
        });

        modelBuilder.Entity<VwItemhead>(entity =>
        {
            entity.ToView("vw_itemhead");
        });

        modelBuilder.Entity<VwItemheadDesc>(entity =>
        {
            entity.ToView("vw_itemhead_Desc");
        });

        modelBuilder.Entity<VwItemmaster>(entity =>
        {
            entity.ToView("vw_itemmaster");
        });

        modelBuilder.Entity<VwItemmasterIsd>(entity =>
        {
            entity.ToView("vw_itemmaster_isd");
        });

        modelBuilder.Entity<VwItemsFallUnderScheme>(entity =>
        {
            entity.ToView("Vw_ItemsFallUnderScheme");
        });

        modelBuilder.Entity<VwLiftDetailsForScheme>(entity =>
        {
            entity.ToView("Vw_LiftDetailsForScheme");
        });

        modelBuilder.Entity<VwOsStmt>(entity =>
        {
            entity.ToView("VW_OS_STMT");
        });

        modelBuilder.Entity<VwParentBranch>(entity =>
        {
            entity.ToView("Vw_ParentBranch");
        });

        modelBuilder.Entity<VwPartyM>(entity =>
        {
            entity.ToView("Vw_PartyM");
        });

        modelBuilder.Entity<VwPaymentMadeDetailsForScheme>(entity =>
        {
            entity.ToView("Vw_PaymentMadeDetailsForScheme");
        });

        modelBuilder.Entity<VwPendingOrder>(entity =>
        {
            entity.ToView("Vw_PendingOrders");
        });

        modelBuilder.Entity<VwPhysicalStockVerification>(entity =>
        {
            entity.ToView("VW_PhysicalStockVerification");
        });

        modelBuilder.Entity<VwPodetail>(entity =>
        {
            entity.ToView("VW_POdetail");
        });

        modelBuilder.Entity<VwPoheader>(entity =>
        {
            entity.ToView("VW_POheader");
        });

        modelBuilder.Entity<VwPoindent>(entity =>
        {
            entity.ToView("VW_Poindent");
        });

        modelBuilder.Entity<VwPriceMapping>(entity =>
        {
            entity.ToView("VW_PriceMapping");
        });

        modelBuilder.Entity<VwProdLiftSal>(entity =>
        {
            entity.ToView("vw_prod_lift_sal");
        });

        modelBuilder.Entity<VwProdSlip>(entity =>
        {
            entity.ToView("VW_PROD_SLIP");
        });

        modelBuilder.Entity<VwProductwiseSalesSummary>(entity =>
        {
            entity.ToView("VW_ProductwiseSalesSummary");
        });

        modelBuilder.Entity<VwPurchaseConsignmentItem>(entity =>
        {
            entity.ToView("VW_PurchaseConsignmentItem");
        });

        modelBuilder.Entity<VwPurchaseInvoice>(entity =>
        {
            entity.ToView("Vw_PurchaseInvoice");
        });

        modelBuilder.Entity<VwPurchaseInvoiceDetail>(entity =>
        {
            entity.ToView("VW_PurchaseInvoiceDetail");
        });

        modelBuilder.Entity<VwPurchaseInvoiceHeader>(entity =>
        {
            entity.ToView("VW_PurchaseInvoiceHeader");
        });

        modelBuilder.Entity<VwPurchaseOrder>(entity =>
        {
            entity.ToView("Vw_PurchaseOrder");
        });

        modelBuilder.Entity<VwPurchaseOrderAdvanceTotalAdjustmentAmt>(entity =>
        {
            entity.ToView("VW_PurchaseOrderAdvance_TotalAdjustmentAmt");
        });

        modelBuilder.Entity<VwRequestVoucher>(entity =>
        {
            entity.ToView("VW_RequestVoucher");
        });

        modelBuilder.Entity<VwRtFinal>(entity =>
        {
            entity.ToView("VW_RT_FINAL");
        });

        modelBuilder.Entity<VwSalesHead>(entity =>
        {
            entity.ToView("vw_sales_head");
        });

        modelBuilder.Entity<VwSalesList>(entity =>
        {
            entity.ToView("vw_sales_list");
        });

        modelBuilder.Entity<VwSalesOfficerM>(entity =>
        {
            entity.ToView("VW_SalesOfficerM");
        });

        modelBuilder.Entity<VwScheme>(entity =>
        {
            entity.ToView("Vw_Scheme");
        });

        modelBuilder.Entity<VwSchemeAppliedFor>(entity =>
        {
            entity.ToView("Vw_SchemeAppliedFor");
        });

        modelBuilder.Entity<VwSelectAreaSomappingForCurrentDate>(entity =>
        {
            entity.ToView("VW_SelectAreaSOMapping_ForCurrentDate");
        });

        modelBuilder.Entity<VwSelectPurchaseInvoiceInventoryTransListUid>(entity =>
        {
            entity.ToView("VW_SelectPurchaseInvoiceInventoryTransListUID");
        });

        modelBuilder.Entity<VwSelectPurchaseInvoicePoheaderUid>(entity =>
        {
            entity.ToView("VW_SelectPurchaseInvoicePOHeaderUID");
        });

        modelBuilder.Entity<VwSerinvFinal>(entity =>
        {
            entity.ToView("VW_SERINV_FINAL");

            entity.Property(e => e.Decl).IsFixedLength();
            entity.Property(e => e.Desc).IsFixedLength();
        });

        modelBuilder.Entity<VwServiceinvHead>(entity =>
        {
            entity.ToView("vw_serviceinv_head");
        });

        modelBuilder.Entity<VwServiceinvList>(entity =>
        {
            entity.ToView("vw_serviceinv_list");
        });

        modelBuilder.Entity<VwSodetail>(entity =>
        {
            entity.ToView("VW_SODetail");
        });

        modelBuilder.Entity<VwSoforwardBranch>(entity =>
        {
            entity.ToView("VW_SOForwardBranch");
        });

        modelBuilder.Entity<VwSoheader>(entity =>
        {
            entity.ToView("VW_SOHeader");
        });

        modelBuilder.Entity<VwSoheaderHoapproved>(entity =>
        {
            entity.ToView("VW_SOHeaderHOApproved");
        });

        modelBuilder.Entity<VwStmtofac>(entity =>
        {
            entity.ToView("VW_stmtofac");
        });

        modelBuilder.Entity<VwSupVoucherMatch>(entity =>
        {
            entity.ToView("VW_SupVoucherMatch");
        });

        modelBuilder.Entity<VwSupVoucherMatchCrTotalAdjustment>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchCrTotalAdjustment");
        });

        modelBuilder.Entity<VwSupVoucherMatchCrTotalAdjustmentReport>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchCrTotalAdjustmentReport");
        });

        modelBuilder.Entity<VwSupVoucherMatchDrTotalAdjustment>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchDrTotalAdjustment");
        });

        modelBuilder.Entity<VwSupVoucherMatchDrTotalAdjustmentReport>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchDrTotalAdjustmentReport");
        });

        modelBuilder.Entity<VwSupVoucherMatchInDetail>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchInDetail");
        });

        modelBuilder.Entity<VwSupVoucherMatchReport>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchReport");
        });

        modelBuilder.Entity<VwSupVoucherMatchWithPartyUid>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchWithPartyUID");
        });

        modelBuilder.Entity<VwSupVoucherMatchWithPartyUidByStatus>(entity =>
        {
            entity.ToView("VW_SupVoucherMatchWithPartyUID_ByStatus");
        });

        modelBuilder.Entity<VwTaxDetail>(entity =>
        {
            entity.ToView("VW_TaxDetails");
        });

        modelBuilder.Entity<VwTempVoucherMatchLink>(entity =>
        {
            entity.ToView("VW_Temp_VoucherMatchLink");
        });

        modelBuilder.Entity<VwTestBranch>(entity =>
        {
            entity.ToView("VW_Test_Branch");
        });

        modelBuilder.Entity<VwVoucher>(entity =>
        {
            entity.ToView("VW_Voucher");
        });

        modelBuilder.Entity<VwVoucherDetail>(entity =>
        {
            entity.ToView("VW_VoucherDetail");
        });

        modelBuilder.Entity<VwVoucherForBankDeposit>(entity =>
        {
            entity.ToView("VW_VoucherForBankDeposit");
        });

        modelBuilder.Entity<VwVoucherHeader>(entity =>
        {
            entity.ToView("VW_VoucherHeader");
        });

        modelBuilder.Entity<VwVoucherMatch>(entity =>
        {
            entity.ToView("Vw_VoucherMatch");
        });

        modelBuilder.Entity<VwVoucherMatchInDetail>(entity =>
        {
            entity.ToView("Vw_VoucherMatchInDetail");
        });

        modelBuilder.Entity<VwVoucherMatchLink>(entity =>
        {
            entity.ToView("Vw_VoucherMatchLink");
        });

        modelBuilder.Entity<VwVoucherdoc>(entity =>
        {
            entity.ToView("Vw_voucherdoc");
        });

        modelBuilder.Entity<VwVoucr>(entity =>
        {
            entity.ToView("VW_VOUCR");
        });

        modelBuilder.Entity<VwVoudb>(entity =>
        {
            entity.ToView("VW_VOUDB");
        });

        modelBuilder.Entity<VwpaymentFinal>(entity =>
        {
            entity.ToView("VWPayment_Final");
        });

        modelBuilder.Entity<Vwvou>(entity =>
        {
            entity.ToView("VWVou");
        });

        modelBuilder.Entity<Vwvoup>(entity =>
        {
            entity.ToView("VWVOUP");
        });

        modelBuilder.Entity<_159>(entity =>
        {
            entity.ToView("159");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
