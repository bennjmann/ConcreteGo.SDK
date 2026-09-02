using ConcreteGo.Api.Client.Models.AccountingCategories;
using ConcreteGo.Api.Client.Models.CloudBatchInventory;
using ConcreteGo.Api.Client.Models.Company;
using ConcreteGo.Api.Client.Models.CreditCodes;
using ConcreteGo.Api.Client.Models.Customers;
using ConcreteGo.Api.Client.Models.Divisions;
using ConcreteGo.Api.Client.Models.Employees;
using ConcreteGo.Api.Client.Models.InventoryTransactions;
using ConcreteGo.Api.Client.Models.Invoices;
using ConcreteGo.Api.Client.Models.ItemCategories;
using ConcreteGo.Api.Client.Models.Items;
using ConcreteGo.Api.Client.Models.ItemTypes;
using ConcreteGo.Api.Client.Models.Jobs;
using ConcreteGo.Api.Client.Models.Locations;
using ConcreteGo.Api.Client.Models.Orders;
using ConcreteGo.Api.Client.Models.Plants;
using ConcreteGo.Api.Client.Models.PriceCategories;
using ConcreteGo.Api.Client.Models.Projects;
using ConcreteGo.Api.Client.Models.Quotes;
using ConcreteGo.Api.Client.Models.ReasonCodes;
using ConcreteGo.Api.Client.Models.TaxAuthority;
using ConcreteGo.Api.Client.Models.TaxCodes;
using ConcreteGo.Api.Client.Models.TaxLocations;
using ConcreteGo.Api.Client.Models.Tickets;
using ConcreteGo.Api.Client.Models.Trucks;
using ConcreteGo.Api.Client.Models.UOMs;
using ConcreteGo.Api.Client.Models.Version;

namespace ConcreteGo.Api.Client;

public interface IConcreteGoApiClient
{
    
    
    
    // Top-level methods
    Task<List<AccountingCategoryRet>?> GetAccountingCategories(Action<AccountingCategoryOptions>? settings = null);
    Task<List<CustomerRet>?> GetCustomersAsync(Action<CustomerOptions>? settings = null);
    Task<List<CustomerUpdateRet>?> AddOrUpdateCustomer(CustomerAddOrUpdateRequest data);
    Task<List<EmployeeRet>?> GetEmployeesAsync(Action<EmployeeOptions>? settings = null);
    Task<List<BatchInventoryRet>?> GetCloudBatchInventoryAsync(Action<CloudBatchInventoryOptions>? settings = null);
    Task<List<CompanyRet>?> GetCompanyAsync(Action<CompanyOptions>? settings = null);
    Task<List<CreditCodeRet>?> GetCreditCodesAsync(Action<CreditCodeOptions>? settings = null);
    Task<List<DivisionRet>?> GetDivisionsAsync(Action<DivisionRequestOptions>? settings = null);
    Task<List<ItemRet>?> GetItemsAsync(Action<ItemRequestOptions>? settings = null);
    Task<List<ItemRet>?> AddOrUpdateItem(ItemAddOrUpdateRequest data);
    Task<ItemUpdateResponse?> AddOrUpdateItemWithResponse(ItemAddOrUpdateRequest data);
    Task<List<ItemCategoryRet>?> GetItemCategoriesAsync(Action<ItemCategoryOptions>? settings = null);
    Task<List<ItemTypeRet>?> GetItemTypesAsync(Action<ItemTypeOptions>? settings = null);
    Task<List<InventoryTransactionRet>?> GetInventoryTransactionsAsync(Action<InventoryTransactionOptions>? settings = null);
    Task<List<InvoiceRet>?> GetInvoicesAsync(Action<InvoiceRequestOptions>? settings = null);
    Task<List<JobRet>?> GetJobsAsync(Action<JobRequestOptions>? settings = null);
    Task<List<LocationRet>?> GetLocationsAsync(Action<LocationOptions>? settings = null);
    Task<List<LocationRet>?> AddOrUpdateLocation(LocationAddOrUpdateRequest data);
    Task<List<OrderRet>?> GetOrdersAsync(Action<OrderRequestOptions>? settings = null);
    Task<List<OrderUpdateRet>?> AddOrUpdateOrderAsync(OrderAddOrUpdateRequest data);
    Task<List<PlantRet>?> GetPlantsAsync(Action<PlantOptions>? settings = null);
    Task<List<PlantRet>?> AddOrUpdatePlant(PlantAddOrUpdateRequest data);
    Task<List<PriceCategoryRet>?> GetPriceCategories(Action<PriceCategoryOptions>? settings = null);
    Task<List<ProjectRet>?> GetProjectsAsync(Action<ProjectRequestOptions>? settings = null);
    Task<List<ProjectRet>?> AddOrUpdateProject(ProjectAddOrUpdateRequest data);
    Task<List<QuoteRet>?> GetQuotesAsync(Action<QuoteRequestOptions>? settings = null);
    Task<List<ReasonCodeRet>?> GetReasonCodesAsync(Action<ReasonCodeOptions>? settings = null);
    Task<List<TaxAuthorityRet>?> GetTaxAuthoritiesAsync(Action<TaxAuthorityOptions>? settings = null);
    Task<List<TaxCodeRet>?> GetTaxCodesAsync(Action<TaxCodeOptions>? settings = null);
    Task<List<TaxLocationRet>?> GetTaxLocationsAsync(Action<TaxLocationOptions>? settings = null);
    Task<List<TicketRet>?> GetTicketsAsync(Action<TicketRequestOptions>? settings = null);
    Task<List<TicketUpdateRet>?> AddOrUpdateTicketAsync(TicketAddOrUpdateRequest data);
    Task<List<TruckRet>?> GetTrucksAsync(Action<TruckRequestOptions>? settings = null);
    public async Task<List<TruckRet>?> AddOrUpdateTruck(TruckAddOrUpdateRequest data);
    public async Task<List<UOMRet>?> GetUOMsAsync(Action<UOMRequestOptions>? settings = null);
    public async Task<VersionRet?> GetVersionAsync(Action<VersionOptions>? settings = null);
}