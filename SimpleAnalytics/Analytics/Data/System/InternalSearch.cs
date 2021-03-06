
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class InternalSearch
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("A boolean to distinguish whether internal search was used in a session. Values are Visits With Site Search and Visits Without Site Search.")]
            public static DataItem searchUsed = new DataItem("searchUsed");
                                      
            [DescriptionAttribute("Search terms used by visitors within your property.")]
            public static DataItem searchKeyword = new DataItem("searchKeyword");
                                      
            [DescriptionAttribute("Subsequent keyword search terms or strings entered by users after a given initial string search.")]
            public static DataItem searchKeywordRefinement = new DataItem("searchKeywordRefinement");
                                      
            [DescriptionAttribute("The categories used for the internal search if you have this enabled for your profile. For example, you might have product categories such as electronics, furniture, or clothing.")]
            public static DataItem searchCategory = new DataItem("searchCategory");
                                      
            [DescriptionAttribute("A page where the user initiated an internal search on your property.")]
            public static DataItem searchStartPage = new DataItem("searchStartPage");
                                      
            [DescriptionAttribute("A page that the user visited after performing an internal search on your property.")]
            public static DataItem searchDestinationPage = new DataItem("searchDestinationPage");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The number of times a search result page was viewed after performing a search.")]
            public static DataItem searchResultViews = new DataItem("searchResultViews");
                                      
            [DescriptionAttribute("The total number of unique keywords from internal searches within a session. For example if shoes was searched for 3 times in a session, it will be only counted once.")]
            public static DataItem searchUniques = new DataItem("searchUniques");
                                      
            [DescriptionAttribute("The total number of sessions that included an internal search")]
            public static DataItem searchVisits = new DataItem("searchVisits");
                                      
            [DescriptionAttribute("The average number of subsequent page views made on your property after a use of your internal search feature.")]
            public static DataItem searchDepth = new DataItem("searchDepth");
                                      
            [DescriptionAttribute("The total number of times a refinement (transition) occurs between internal search keywords within a session. For example if the sequence of keywords is: shoes, shoes, pants, pants, this metric will be one because the transition between shoes and pants is different.")]
            public static DataItem searchRefinements = new DataItem("searchRefinements");
                                      
            [DescriptionAttribute("The visit duration to your property where a use of your internal search feature occurred.")]
            public static DataItem searchDuration = new DataItem("searchDuration");
                                      
            [DescriptionAttribute("The number of exits on your site that occurred following a search result from your internal search feature.")]
            public static DataItem searchExits = new DataItem("searchExits");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The average number of times people viewed a search results page after performing a search. (ga:searchResultViews / ga:searchUniques ) ")]
            public static DataItem avgSearchResultViews = new DataItem("avgSearchResultViews");
                                      
            [DescriptionAttribute("The percentage of visits with search. (ga:searchVisits / ga:visits ) ")]
            public static DataItem percentVisitsWithSearch = new DataItem("percentVisitsWithSearch");
                                      
            [DescriptionAttribute("The average number of pages people viewed after performing a search on your property. (ga:searchDepth / ga:searchUniques ) ")]
            public static DataItem avgSearchDepth = new DataItem("avgSearchDepth");
                                      
            [DescriptionAttribute("The percentage of number of times a refinement (i.e., transition) occurs between internal search keywords within a session. (ga:searchRefinements / ga:searchResultViews ) ")]
            public static DataItem percentSearchRefinements = new DataItem("percentSearchRefinements");
                                      
            [DescriptionAttribute("The average amount of time people spent on your property after searching. (ga:searchDuration / ga:searchUniques ) ")]
            public static DataItem avgSearchDuration = new DataItem("avgSearchDuration");
                                      
            [DescriptionAttribute("The percentage of searches that resulted in an immediate exit from your property. (ga:searchExits / ga:searchUniques ) ")]
            public static DataItem searchExitRate = new DataItem("searchExitRate");

			[DescriptionAttribute("The percentage of search visits (i.e., visits that included at least one search) which resulted in a conversion to the requested goal number. (ga:goalXXCompletions / ga:searchUniques ) ")]
			public static DataItem searchGoalXXConversionRate(int index) { return new DataItem("searchGoalXXConversionRate", index); }
                                      
            [DescriptionAttribute("The percentage of search visits (i.e., visits that included at least one search) which resulted in a conversion to at least one of your goals. (ga:goalCompletionsAll / ga:searchUniques ) ")]
            public static DataItem searchGoalConversionRateAll = new DataItem("searchGoalConversionRateAll");
                                      
            [DescriptionAttribute("The average goal filter of a search on your property. (ga:goalValueAll / ga:searchUniques ) ")]
            public static DataItem goalValueAllPerSearch = new DataItem("goalValueAllPerSearch");
                                      
            }
        }
    }
}
