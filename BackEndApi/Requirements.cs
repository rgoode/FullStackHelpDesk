namespace BackEndApi
{
    public class Requirements
    {
        /*
         * Corn: Create services folder that will allow us to link this to the sql data base. You can use your sql server string
         *       This includes Services Folder with DAL Models folder in it and HelpDeskContext.cs  (DB context)
         *       In DAL Models folder, HelpDeskTable.cs
         *       
         * Kyle: Create at least two API controllers that http: get/post/put/delete (any others needed)
         * 
         * Two databases: In-Flight DB
         *                Completed DB
         *                
         * DB Columns: 
         *             ID
         *             Request Title*
         *             Submitter Name*
         *             Problem*
         *             Solution*
         *             Priority Level (number)*
         *             
         *             Time Stamp Request Submitted (system does this when user submits request)
         *             
         *             Resolved By - Completed by the person who did the work, not the submiter
         *             Favorited (boolean y/n) - Completed by the person who did the work, not the submiter
         *             Time Stamp Request Resolved (system does this when the worker resolves the request)
         *             
         * Methods:
         *             HTTPGET:             Get All Requests
         *             HTTPGET:             Get Single Request
         *             HTTPPOST:            New Request 
         *             HTTPPOST/HTTPDELETE: Complete Request - this will add to completed DB and remove from in-flight DB 
         *             HTTPPUT:             Favorite request - This will modify the angular view later
         *             HTTPGET:             Get All Favorited Requests
         * 
         */


    }
}
