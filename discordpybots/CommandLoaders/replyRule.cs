using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Rules:
/// C Contains
/// S Starts With
/// E Ends With
/// M More Then
/// L Less Then 
/// I Identity
/// X Custom Operator

namespace discordpybots.CommandLoaders
{
	class ReplyRule
	{
		// IDictionary<Char, String> mathRulesDict = new Dictionary<Char, String>();
		Char rule;
		String val;
		String customOperator;
		public ReplyRule(Char argRule,String argVal,String argCustomOperator = "")
		{
			/// mathRulesDict.Add('M',">");
			/// mathRulesDict.Add('L',"<");
			/// mathRulesDict.Add('E',"=");
			/// mathRulesDict.Add('C', "in");
			rule = argRule;
			val = argVal;
			customOperator = argCustomOperator;
		}
		public String generateStatement()
		{
			if (rule == 'C')
			{

			}
		}
	}
}
