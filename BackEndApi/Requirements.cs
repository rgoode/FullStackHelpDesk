namespace BackEndApi
{
    public class Requirements
    {
        /*
         * Corn: Create services folder that will allow us to link this to the sql data base. You can use your sql server string
         *       This includes Services Folder with DAL Models folder in it and HelpDeskContext.cs  (DB context)
         *       In DAL Models folder, HelpDeskTable.cs - DONE
         *       
         * Kyle: Create at least two API controllers that http: get/post/put/delete (any others needed)
         * 
         * Two tables:    Tickets TB - DONE
         *                Users TB - DONE
         *                
         * DB Columns: - DONE
         *             ID
         *             Request Title*
         *             Submitter Name*
         *             Problem*
         *             Solution*
         *             Priority Level (number)*
         *             
         *             Time Stamp Request Submitted (system does this when user submits request)
         *             
         *             Assigned To - Completed by the person who did the work, not the submiter
         *             Resolution Status (i.e. Completed, Not Completed, In Progress)
         *             Favorited (boolean y/n) - Completed by the person who did the work, not the submiter
         *             Time Stamp Request Resolved (system does this when the worker resolves the request)
         *             
         * Methods:
         *             HTTPGET:             Get All Requests - DONE
         *             HTTPGET:             Get Single Request
         *             HTTPPOST:            New Request 
         *             HTTPPOST/HTTPDELETE: Complete Request - this will add to completed DB and remove from in-flight DB 
         *             HTTPPATCH:           Favorite request - This will modify the angular view later
         *             HTTPPATCH:           Update Ticket with worker information
         *             HTTPGET:             Get All Favorited Requests
         * 
         * 
         * Form For Requestor:
         *      Requestor Name:
         *      Requestor Email:
         *      Subject Line:
         *      What is the problem?
         *      Submitted Time (auto generated)
         * 
         * Form For Technician (User):
         *      Assigned To:
         *      Priority:
         *      Status:
         *      Solution:
         *      Time Resolved (auto generated)
         * 
         *         
         * 
         */


    }
}
