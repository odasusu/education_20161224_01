namespace education_20161224_01
{
    public class StringUtils
    {
        /// <summary>
        /// インスタンスから部分文字列を取得します。検索は、指定した文字位置から開始されます。
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex">開始位置</param>
        /// <param name="length">長さ</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string Substring(string str, int startIndex, int length)
        {
            return str.Substring(startIndex, length);
        }
    }
}
