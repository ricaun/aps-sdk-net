using Autodesk.Webhooks;
using Autodesk.Webhooks.Model;
using Autodesk.SDKManager;

namespace Samples
{
    class Webhooks
    {
        string token = "<token>";
        string hookId = "<hook-id>";
        WebhooksClient webhooksClient = null!;

        public void Initialise()
        {
            // Instantiate SDK manager as below.   
            // You can also optionally pass configurations, logger, etc. 
            SDKManager sdkManager = SdkManagerBuilder
                  .Create() // Creates SDK Manager Builder itself.
                  .Build();

            // Instantiate WebhooksClient using the created SDK manager
            webhooksClient = new WebhooksClient(sdkManager);

        }


        // Create post request body to receive the notification on a specified event.
        public async Task CreateSystemEventHookAsync()
        {
            HookPayload createSpecifiedEventHook = new HookPayload();
            createSpecifiedEventHook.CallbackUrl = "<callbackUrl>";
            createSpecifiedEventHook.Scope = createSpecifiedEventHook.Scope.SetScope(Scopes.Workflow, "<my-workflow-id>");



            // Add new webhook to receive the notification on a specified event.
            HttpResponseMessage createSpecifiedEventHookResponse = await webhooksClient.CreateSystemEventHookAsync(system: Systems.Derivative, _event: Events.ExtractionFinished, hookPayload: createSpecifiedEventHook, accessToken: token);
            Console.WriteLine(createSpecifiedEventHookResponse.StatusCode);
            Console.WriteLine(createSpecifiedEventHookResponse.Content);
        }


        // Retrieves a paginated list of all the webhooks. If the pageState query string is not specified, the first page is returned.
        public async Task GetHooksAsync()
        {
            HooksResult getHooks = await webhooksClient.GetHooksAsync(accessToken: token);
            // get hooks next link meant for pagination
            string getHooksLink = getHooks.Links.Next;
            // Get list of hooks data
            List<HooksResultData> getHooksData = getHooks.Data;
            foreach (var currentHook in getHooksData)
            {
                string hook_Id = currentHook.HookId;
                string tenant = currentHook.Tenant;
                string callback_Url = currentHook.CallbackUrl;
                string created_by = currentHook.CreatedBy;
                string hook_event = currentHook.Event;
                string created_date = currentHook.CreatedDate;
                string last_updated_date = currentHook.LastUpdatedDate;
                string system_hook = currentHook.System;
                string creator_type = currentHook.CreatorType;
                string status = currentHook.Status;
                bool? auto_reactivate_hook = currentHook.AutoReactivateHook;
                string hook_expiry = currentHook.HookExpiry;
            }

        }


        // Retrieves a paginated list of webhooks created in the context of a Client or Application. This API accepts 2-legged token of the application only. If the pageState query string is not specified, the first page is returned.
        public async Task GetAppHooksAsync()
        {
            HooksResult getAppHooks = await webhooksClient.GetAppHooksAsync(accessToken: token);
            // get hooks next link meant for pagination
            string getAppHooksLink = getAppHooks.Links.Next;
            // Get a list of hooks data
            List<HooksResultData> appHooksData = getAppHooks.Data;
            foreach (var currentHook in appHooksData)
            {
                string hook_Id = currentHook.HookId;
                string tenant = currentHook.Tenant;
                string callback_Url = currentHook.CallbackUrl;
                string created_by = currentHook.CreatedBy;
                string hook_event = currentHook.Event;
                string created_date = currentHook.CreatedDate;
                string last_updated_date = currentHook.LastUpdatedDate;
                string system_hook = currentHook.System;
                string creator_type = currentHook.CreatorType;
                string status = currentHook.Status;
                bool? auto_reactivate_hook = currentHook.AutoReactivateHook;
                string hook_expiry = currentHook.HookExpiry;
            }

        }


        // Retrieves a paginated list of all the webhooks for a specified system. If the pageState query string is not specified, the first page is returned.
        public async Task GetSystemHooksAsync()
        {
            HooksResult getSystemHooks = await webhooksClient.GetSystemHooksAsync(system: Systems.Data, accessToken: token);
            // get hooks next link meant for pagination
            string getSystemHooksLink = getSystemHooks.Links.Next;
            // Get a list of hooks data
            List<HooksResultData> getSystemHooksData = getSystemHooks.Data;
            foreach (var currentHook in getSystemHooksData)
            {
                string hook_Id = currentHook.HookId;
                string tenant = currentHook.Tenant;
                string callback_Url = currentHook.CallbackUrl;
                string created_by = currentHook.CreatedBy;
                string hook_event = currentHook.Event;
                string created_date = currentHook.CreatedDate;
                string last_updated_date = currentHook.LastUpdatedDate;
                string system_hook = currentHook.System;
                string creator_type = currentHook.CreatorType;
                string status = currentHook.Status;
                bool? auto_reactivate_hook = currentHook.AutoReactivateHook;
                string hook_expiry = currentHook.HookExpiry;
            }
        }


        // Retrieves a paginated list of all the webhooks for a specified event. If the pageState query string is not specified, the first page is returned.
        public async Task GetSystemEventHooksAsync()
        {
            HooksResult getSystemEventHooks = await webhooksClient.GetSystemEventHooksAsync(system: Systems.Data, _event: Events.DmVersionAdded, accessToken: token);
            // get hooks next link meant for pagination
            string getSystemEventHooksLink = getSystemEventHooks.Links.Next;
            // Get a list of hooks data
            List<HooksResultData> getSystemEventHooksData = getSystemEventHooks.Data;
            foreach (var currentHook in getSystemEventHooksData)
            {
                string hook_Id = currentHook.HookId;
                string tenant = currentHook.Tenant;
                string callback_Url = currentHook.CallbackUrl;
                string created_by = currentHook.CreatedBy;
                string hook_event = currentHook.Event;
                string created_date = currentHook.CreatedDate;
                string last_updated_date = currentHook.LastUpdatedDate;
                string system_hook = currentHook.System;
                string creator_type = currentHook.CreatorType;
                string status = currentHook.Status;
                bool? auto_reactivate_hook = currentHook.AutoReactivateHook;
                string hook_expiry = currentHook.HookExpiry;
            }

        }


        // Get details of a webhook based on its webhook ID
        public async Task GetHookDetailsAsync()
        {
            HookDetailsResult getSystemEventHook = await webhooksClient.GetHookDetailsAsync(system: Systems.Data, _event: Events.DmVersionAdded, hookId: hookId, accessToken: token);
            // Get callbackUrl
            string callbackUrl = getSystemEventHook.CallbackUrl;
            Console.WriteLine(getSystemEventHook);


            HttpResponseMessage deleteHookResponse = await webhooksClient.DeleteSystemEventHookAsync(system: Systems.Data, _event: Events.DmVersionAdded, hookId: hookId, accessToken: token);
            Console.WriteLine(deleteHookResponse.StatusCode);
            Console.WriteLine(deleteHookResponse.Content);

        }


        // Create update hook request body
        public async Task PatchSystemEventHookAsync()
        {
            ModifyHookPayload updateHook = new ModifyHookPayload();
            updateHook.Status = "<status>";

            // Successful deactivation of a webhook:
            HttpResponseMessage updateHookResponse = await webhooksClient.PatchSystemEventHookAsync(system: Systems.Data, _event: Events.DmVersionAdded, hookId: hookId, accessToken: token);
            Console.WriteLine(updateHookResponse.StatusCode);
            Console.WriteLine(updateHookResponse.Content);
        }


        // Create post request body to receive the notification on all the events.
        public async Task CreateSystemHookAsync()
        {
            HookPayload createAllEventsHook = new HookPayload();
            createAllEventsHook.CallbackUrl = "<callbackUrl>";
            createAllEventsHook.Scope = createAllEventsHook.Scope.SetScope(Scopes.Workflow, "<my-workflow-id>");


            // Add new webhooks to receive the notification on all the events.
            HookCreationResult createAllEventsHooks = await webhooksClient.CreateSystemHookAsync(system: Systems.Derivative, hookPayload: createAllEventsHook, accessToken: token);
            List<HookCreationResultHooks> allEventsHooks = createAllEventsHooks.Hooks;
            foreach (var currentHook in allEventsHooks)
            {
                string hook_Id = currentHook.HookId;
                string tenant = currentHook.Tenant;
                string callback_Url = currentHook.CallbackUrl;
                string created_by = currentHook.CreatedBy;
                string hook_event = currentHook.Event;
                string created_date = currentHook.CreatedDate;
                string last_updated_date = currentHook.LastUpdatedDate;
                string system_hook = currentHook.System;
                string creator_type = currentHook.CreatorType;
                string status = currentHook.Status;
                bool? auto_reactivate_hook = currentHook.AutoReactivateHook;
                string urn = currentHook.Urn;
                string _self = currentHook.Self;

                HookDetailsResultScope scope = currentHook.Scope;
                string folderId = scope.Folder;
            }
        }


        public async void Main()
        {
            // Initialise SDKManager & WebhooksClient
            Initialise();
            // Call respective methods
            await CreateSystemEventHookAsync();
            await GetHooksAsync();
            await GetAppHooksAsync();
            await GetSystemHooksAsync();
            await GetSystemEventHooksAsync();
            await GetHookDetailsAsync();
            await PatchSystemEventHookAsync();
            await CreateSystemHookAsync();
        }
    }
}