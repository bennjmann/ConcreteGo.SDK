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
using ConcreteGo.Api.Client.Models.locations;
using ConcreteGo.Api.Client.Models.Locations;
using ConcreteGo.Api.Client.Models.Options;
using ConcreteGo.Api.Client.Models.Orders;
using ConcreteGo.Api.Client.Models.Plants;
using ConcreteGo.Api.Client.Models.PriceCategories;
using ConcreteGo.Api.Client.Models.Processing;
using ConcreteGo.Api.Client.Models.Projects;
using ConcreteGo.Api.Client.Models.Quotes;
using ConcreteGo.Api.Client.Models.TaxAuthority;
using ConcreteGo.Api.Client.Models.TaxCodes;
using ConcreteGo.Api.Client.Models.TaxLocations;
using ConcreteGo.Api.Client.Models.Tickets;
using ConcreteGo.Api.Client.Models.Trucks;
using ConcreteGo.Api.Client.Models.UOMs;
using ConcreteGo.Api.Client.Models.Version;
using Exceptionless.DateTimeExtensions;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WebcreteAPI;

namespace ConcreteGo.Api.Client
{
    public class ConcreteGoApiClient
    {
        private readonly string _username;
        private readonly string _password;
        private readonly string _appId;
        private readonly string _appKey;
        private readonly string? _slug;
        private readonly WebcreteAPISoapClient _api = new WebcreteAPISoapClient(new WebcreteAPISoapClient.EndpointConfiguration());
        private TicketHeader? _ticketHeader;
        private DateTime? _loginTime;

        // Constructor for options pattern with dependency injection
        public ConcreteGoApiClient(IOptions<ConcreteGoApiOptions> options)
            : this(options.Value.Username, options.Value.Password, options.Value.AppId, options.Value.AppKey, options.Value.Slug)
        {
        }

        // Original constructor for backward compatibility and explicit parameter usage
        public ConcreteGoApiClient(string username, string password, string appId, string appKey, string? slug)
        {
            // Validate required parameters
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty", nameof(username));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty", nameof(password));
            if (string.IsNullOrWhiteSpace(appId))
                throw new ArgumentException("AppId cannot be null or empty", nameof(appId));
            if (string.IsNullOrWhiteSpace(appKey))
                throw new ArgumentException("AppKey cannot be null or empty", nameof(appKey));

            _username = username;
            _password = password;
            _appId = appId;
            _appKey = appKey;
            _slug = slug;
        }

        #region Login

        private async Task LoginAsync()
        {
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            //Get public key to encrypt password.
            try
            {
                var publicKeyResponse = await _api.GetPublicKeyAsync(_appId, _appKey);
                _ticketHeader = publicKeyResponse.TicketHeader;
                key.FromXmlString(publicKeyResponse.GetPublicKeyResult);

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }

            //Encrypt credentials.
            UnicodeEncoding enc = new UnicodeEncoding();
            var encryptedPassword = key.Encrypt(enc.GetBytes(_password), false);

            //Attempt login.
            try
            {
                var loginResult = await _api.LoginAsync(_ticketHeader, _username, encryptedPassword, _slug);
                if (loginResult.LoginResult)
                {
                    _loginTime = DateTime.Now;
                }
                else
                {
                    throw new InvalidOperationException("Login failed.  Check credentials.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        #endregion

        #region Accounting Categories

        public async Task<List<AccountingCategoryRet>?> GetAccountingCategories(Action<AccountingCategoryOptions>? settings = null)
        {

            await ManageLogin();
            var options = new AccountingCategoryOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<AccountingCategoryResponse>(request);
            return response?.AccountingCategoryRet;
        }

        #endregion

        #region Customers

        public async Task<List<CustomerRet>?> GetCustomersAsync(Action<CustomerOptions>? settings = null)
        {
            await ManageLogin();
            var options = new CustomerOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<CustomerResponse>(request);
            return response?.CustomerRet;
        }

        public async Task<List<CustomerUpdateRet>?> AddOrUpdateCustomer(CustomerAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<CustomerUpdateResponse>(request);
            return response?.CustomerRet;
        }

        #endregion

        #region Employees

        public async Task<List<EmployeeRet>?> GetEmployeesAsync(Action<EmployeeOptions>? settings = null)
        {
            await ManageLogin();
            var options = new EmployeeOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<EmployeeResponse>(request);
            return response?.EmployeeRet;
        }

        #endregion

        #region CloudBatch Inventory

        public async Task<List<BatchInventoryRet>?> GetCloudBatchInventoryAsync(Action<CloudBatchInventoryOptions>? settings = null)
        {
            await ManageLogin();
            var options = new CloudBatchInventoryOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<CloudBatchInventoryResponse>(request);
            return response?.BatchInventoryRet;
        }

        #endregion

        #region Company

        public async Task<List<CompanyRet>?> GetCompanyAsync(Action<CompanyOptions>? settings = null)
        {
            await ManageLogin();
            var options = new CompanyOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<CompanyResponse>(request);
            return response?.CompanyRet;
        }

        #endregion

        #region CreditCodes

        public async Task<List<CreditCodeRet>?> GetCreditCodesAsync(Action<CreditCodeOptions>? settings = null)
        {
            await ManageLogin();
            var options = new CreditCodeOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<CreditCodeResponse>(request);
            return response?.CreditCodeRet;
        }

        #endregion

        #region Divisions

        public async Task<List<DivisionRet>?> GetDivisionsAsync(Action<DivisionRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new DivisionRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<DivisionResponse>(request);
            return response?.DivisionRet;
        }

        #endregion

        #region Items

        public async Task<List<ItemRet>?> GetItemsAsync(Action<ItemRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new ItemRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<ItemQueryResponse>(request);
            return response?.ItemRet;


        }

        public async Task<List<ItemRet>?> AddOrUpdateItem(ItemAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<ItemUpdateResponse>(request);
            return response?.ItemRet;
        }

        public async Task<ItemUpdateResponse?> AddOrUpdateItemWithResponse(ItemAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<ItemUpdateResponse>(request);
            return response;
        }

        #endregion

        #region Item Categories

        public async Task<List<ItemCategoryRet>?> GetItemCategoriesAsync(Action<ItemCategoryOptions>? settings = null)
        {
            await ManageLogin();
            var options = new ItemCategoryOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<ItemCategoryResponse>(request);
            return response?.ItemCategoryRet;
        }

        #endregion

        #region Item Types

        public async Task<List<ItemTypeRet>?> GetItemTypesAsync(Action<ItemTypeOptions>? settings = null)
        {
            await ManageLogin();
            var options = new ItemTypeOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<ItemTypeResponse>(request);
            return response?.ItemTypeRet;
        }

        #endregion

        #region Inventory Transaction

        public async Task<List<InventoryTransactionRet>?> GetInventoryTransactionsAsync(Action<InventoryTransactionOptions>? settings = null)
        {
            await ManageLogin();
            var options = new InventoryTransactionOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<InventoryTransactionResponse>(request);
            return response?.InventoryTransactionRet;
        }

        #endregion

        #region Invoices

        public async Task<List<InvoiceRet>?> GetInvoicesAsync(Action<InvoiceRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new InvoiceRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<InvoiceQueryResponse>(request);
            return response?.InvoiceRet;
        }

        #endregion

        #region Jobs

        public async Task<List<JobRet>?> GetJobsAsync(Action<JobRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new JobRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<JobQueryResponse>(request);
            return response?.JobRet;
        }

        #endregion

        #region Locations

        public async Task<List<LocationRet>?> GetLocationsAsync(Action<LocationOptions>? settings = null)
        {
            await ManageLogin();
            var options = new LocationOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<LocationResponse>(request);
            return response?.LocationRet;
        }

        public async Task<List<LocationRet>?> AddOrUpdateLocation(LocationAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<LocationUpdateResponse>(request);
            return response?.LocationRet;
        }

        #endregion

        #region Orders

        public async Task<List<OrderRet>?> GetOrdersAsync(Action<OrderRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new OrderRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<OrderQueryResponse>(request);
            return response?.OrderRet;
        }

        public async Task<List<OrderUpdateRet>?> AddOrUpdateOrderAsync(OrderAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<OrderUpdateResponse>(request);
            return response?.OrderRet;        
        }

        #endregion

        #region Plants

        public async Task<List<PlantRet>?> GetPlantsAsync(Action<PlantOptions>? settings = null)
        {
            await ManageLogin();
            var options = new PlantOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<PlantResponse>(request);
            return response?.PlantRet;
        }

        public async Task<List<PlantRet>?> AddOrUpdatePlant(PlantAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<PlantUpdateResponse>(request);
            return response?.PlantRet;
        }

        #endregion

        #region Price Categories

        public async Task<List<PriceCategoryRet>?> GetPriceCategories(Action<PriceCategoryOptions>? settings = null)
        {
            var options = new PriceCategoryOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<PriceCategoryResponse>(request);
            return response?.PriceCategoryRet;
        }

        #endregion

        #region Projects

        public async Task<List<ProjectRet>?> GetProjectsAsync(Action<ProjectRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new ProjectRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<ProjectResponse>(request);
            return response?.ProjectRet;
        }

        public async Task<List<ProjectRet>?> AddOrUpdateProject(ProjectAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<ProjectUpdateResponse>(request);
            return response?.ProjectRet;
        }

        #endregion

        #region Quotes

        public async Task<List<QuoteRet>?> GetQuotesAsync(Action<QuoteRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new QuoteRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<QuoteResponse>(request);
            return response?.QuoteRet;
        }

        #endregion

        #region Tax Authorities

        public async Task<List<TaxAuthorityRet>?> GetTaxAuthoritiesAsync(Action<TaxAuthorityOptions>? settings = null)
        {
            await ManageLogin();
            var options = new TaxAuthorityOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<TaxAuthorityResponse>(request);
            return response?.TaxAuthorityRet;
        }

        #endregion

        #region Tax Codes

        public async Task<List<TaxCodeRet>?> GetTaxCodesAsync(Action<TaxCodeOptions>? settings = null)
        {
            await ManageLogin();
            var options = new TaxCodeOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<TaxCodeResponse>(request);
            return response?.TaxCodeRet;
        }

        #endregion

        #region Tax Locations

        public async Task<List<TaxLocationRet>?> GetTaxLocationsAsync(Action<TaxLocationOptions>? settings = null)
        {
            await ManageLogin();
            var options = new TaxLocationOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<TaxLocationResponse>(request);
            return response?.TaxLocationRet;
        }

        #endregion

        #region Tickets

        public async Task<List<TicketRet>?> GetTicketsAsync(Action<TicketRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new TicketRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<TicketQueryResponse>(request);
            return response?.TicketRet;
        }

        public async Task<List<TicketUpdateRet>?> AddOrUpdateTicketAsync(TicketAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<TicketUpdateResponse>(request);
            return response?.TicketRet;
        }

        #endregion

        #region Trucks

        public async Task<List<TruckRet>?> GetTrucksAsync(Action<TruckRequestOptions>? settings = null!)
        {
            await ManageLogin();
            var options = new TruckRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<TruckResponse>(request);
            return response?.TruckRet;
        }

        public async Task<List<TruckRet>?> AddOrUpdateTruck(TruckAddOrUpdateRequest data)
        {
            await ManageLogin();
            var request = BuildXmlRequest(data);
            var response = await ProcessRequest<TruckUpdateResponse>(request);
            return response?.TruckRet;
        }

        #endregion

        #region UOMs

        public async Task<List<UOMRet>?> GetUOMsAsync(Action<UOMRequestOptions>? settings = null)
        {
            await ManageLogin();
            var options = new UOMRequestOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<UOMResponse>(request);
            return response?.UOMRet;
        }

        #endregion

        #region Version

        public async Task<VersionRet?> GetVersionAsync(Action<VersionOptions>? settings = null)
        {
            await ManageLogin();
            var options = new VersionOptions();
            if (settings != null)
            {
                settings(options);
            }
            var request = BuildXmlRequest(options);
            var response = await ProcessRequest<VersionResponse>(request);
            if (response != null)
            {
                return new VersionRet
                {
                    ConcreteGoVersion = response.ConcreteGoVersion ?? string.Empty,
                    WebcreteVersion = response.WebcreteVersion ?? string.Empty
                };
            }
            return null;
        }

        #endregion

        #region Helpers

        private async Task<T?> ProcessRequest<T>(XDocument request) where T : class, new()
        {
            var response = new ProcessRequestResponse();
            List<T>? result = new List<T>();
            try
            {
                response = await _api.ProcessRequestAsync(_ticketHeader, request.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing request: " + ex.Message);
            }
            try
            {
                //result = Deserialize<T>(response.ProcessRequestResult);
                return Deserialize<T>(response.ProcessRequestResult);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            //return result;
        }

        

        private string? GetXmlRootElementName<T>()
        {
            var type = typeof(T);
            var xmlRootAttribute = type.GetCustomAttribute<XmlRootAttribute>();

            if (xmlRootAttribute != null)
            {
                // Return ElementName if specified, otherwise return the class name
                return !string.IsNullOrEmpty(xmlRootAttribute.ElementName)
                    ? xmlRootAttribute.ElementName
                    : type.Name;
            }

            // If no XmlRoot attribute, return the class name as fallback
            return type.Name;
        }

        private XDocument BuildXmlRequest<T>(T options) where T : class
        {
            var request = new XDocument(
                       new XDeclaration("1.0", "utf-8", "yes"),
                       new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                       new XElement("WebcreteXML",
                       new XElement("WebcreteXMLMsgsRq")));
            
            var innerXml = Serialize(options);
            var innerDoc = XDocument.Parse(innerXml);

            var msgsRq = request.Root?.Element("WebcreteXMLMsgsRq");
            if (msgsRq != null && request.Root != null)
            {
                msgsRq.Add(innerDoc.Root);
            }


            return request;
        }

        private string Serialize<T>(T data)
        {
            var xmlGenericResponseAttributes = new XmlAttributes { XmlRoot = new XmlRootAttribute { Namespace = "", IsNullable = true } };
            var ser = new XmlSerializer(typeof(T));
            using (var writer = new StringWriter())
            {
                ser.Serialize(writer, data);
                return writer.ToString();
            }
        }

        private T? Deserialize<T>(string xml) where T : class, new()
        {
            try
            {
                var boolFixedXml = FixXmlBool(xml);
                var xDoc = XDocument.Parse(boolFixedXml);


                //xDoc.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
                xDoc.Descendants()
                    .Where(e => string.IsNullOrEmpty(e.Value) && !e.HasElements && !e.HasAttributes)
                    .Remove();
                var elementRoot = GetXmlRootElementName<T>();

                //var msgsRs = xDoc.Root?.Element(elementRoot);
                var msgsRs = xDoc.Descendants().FirstOrDefault(x => x.Name.LocalName == elementRoot);

                var serializer = new XmlSerializer(typeof(T));

                using (var reader = new StringReader(msgsRs.ToString()))
                {
                    return (T?)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Simple deserialization error: {ex.Message}");
                return null;
            }
        }

        private async Task ManageLogin()
        {
            //If not logged in, then login.
            if (_loginTime == null)
            {
                await LoginAsync();
                return;
            }

            //If login is old, refresh login.
            if ((DateTime.Now - _loginTime.Value).TotalHours >= 4)
            {
                await LoginAsync();
            }
        }

        private static string FixXmlBool(string xmlText)
        {
            //ConcreteGoApi annoyingly has uppercase on bool values which disagrees with Deserialize.
            var response = string.Empty;
            try
            {
                response = xmlText.Replace("True", "true");
                response = response.Replace("False", "false");
                response = response.Replace("<Active>0</Active>", "<Active>false</Active>");
                response = response.Replace("<Active>1</Active>", "<Active>true</Active>");
                response = response.Replace("<Removed>0</Removed>", "<Removed>false</Removed>");
                response = response.Replace("<Removed>1</Removed>", "<Removed>true</Removed>");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return response;
        }

        #endregion
    }
}
