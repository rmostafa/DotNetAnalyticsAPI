
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class SocialInteractions
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("For social interactions, a filter representing the social network being tracked.")]
            public static DataItem socialInteractionNetwork = new DataItem("socialInteractionNetwork");
                                      
            [DescriptionAttribute("For social interactions, a filter representing the social action being tracked (e.g. +1, bookmark)")]
            public static DataItem socialInteractionAction = new DataItem("socialInteractionAction");
                                      
            [DescriptionAttribute("For social interactions, a filter representing the concatenation of the socialInteractionNetwork and socialInteractionAction action being tracked at this hit level (e.g. Google: +1)")]
            public static DataItem socialInteractionNetworkAction = new DataItem("socialInteractionNetworkAction");
                                      
            [DescriptionAttribute("For social interactions, a filter representing the URL (or resource) which receives the social network action.")]
            public static DataItem socialInteractionTarget = new DataItem("socialInteractionTarget");
                                      
            [DescriptionAttribute("Engagement type. Possible values are Socially Engaged or Not Socially Engaged.")]
            public static DataItem socialEngagementType = new DataItem("socialEngagementType");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The total number of social interactions on your property.")]
            public static DataItem socialInteractions = new DataItem("socialInteractions");
                                      
            [DescriptionAttribute("The number of sessions during which the specified social action(s) occurred at least once. This is based on the the unique combination of socialInteractionNetwork, socialInteractionAction, and socialInteractionTarget.")]
            public static DataItem uniqueSocialInteractions = new DataItem("uniqueSocialInteractions");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The number of social interactions per visit to your property. (ga:socialInteractions / ga:uniqueSocialInteractions ) ")]
            public static DataItem socialInteractionsPerVisit = new DataItem("socialInteractionsPerVisit");
                                      
            }
        }
    }
}
