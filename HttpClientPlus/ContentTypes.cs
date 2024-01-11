namespace IMustafa.Web
{
    public partial struct ContentType
    {
        public string Value { get; set; }
    }

    public partial struct ContentType
    {

        /// <summary>
        /// JSON format .json
        /// </summary>
        public static ContentType Application_Json => new ContentType() { Value = "application/json" };

        /// <summary>
        /// ZIP archive .zip
        /// </summary>
        public static ContentType Application_Zip => new ContentType() { Value = "application/zip" };

        /// <summary>
        /// Adobe Portable Document Format (PDF) .pdf
        /// </summary>
        public static ContentType Application_Pdf => new ContentType() { Value = "application/pdf" };

        /// <summary>
        /// Typescript file .ts
        /// </summary>
        public static ContentType Application_Typescript => new ContentType() { Value = "application/typescript" };

        /// <summary>
        /// XML .xml
        /// </summary>
        public static ContentType Application_Xml => new ContentType() { Value = "application/xml" };

        /// <summary>
        /// Rich Text Format (RTF) .rtf
        /// </summary>
        public static ContentType Application_Rtf => new ContentType() { Value = "application/rtf" };

        /// <summary>
        /// OGG .ogx
        /// </summary>
        public static ContentType Application_Ogg => new ContentType() { Value = "application/ogg" };

        /// <summary>
        /// Microsoft Word .doc
        /// </summary>
        public static ContentType Application_Msword => new ContentType() { Value = "application/msword" };

    }
}