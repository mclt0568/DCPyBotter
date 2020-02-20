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

				return ("( " + val + " in {} )");
			}
			else if (rule == 'S')
			{
				return ("( {}.startswith(" + val + ") )");
			}
			else if (rule == 'E')
			{
				return ("( {}.endswith(" + val + ") )");
			}
			else if (rule == 'I')
			{
				return ("({} == " + val + " )");
			}
			else if (rule == 'D')
			{
				return ("(float({}) == " + val + " )");
			}
			else if (rule == 'L')
			{
				return ("(float({}) < " + val + " )");
			}
			else if (rule == 'M')
			{
				return ("(float({}) > " + val + " )");
			}
			else if (rule == 'X')
			{
				return (val);
			}
			else
			{
				return "(False)";
			}
		}
	}
}
