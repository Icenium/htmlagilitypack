namespace HtmlAgilityPack
{
	public static class HtmlAttributeExtensions
	{
		public static int GetValueStartIndex(this HtmlAttribute attribute)
		{
			return attribute._valuestartindex;
		}

		public static int GetValueLength(this HtmlAttribute attribute)
		{
			return attribute._valuelength;
		}
	}
}
