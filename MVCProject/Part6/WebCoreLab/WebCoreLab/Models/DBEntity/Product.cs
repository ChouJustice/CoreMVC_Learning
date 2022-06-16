namespace WebCoreLab.Models.DBEntity
{
    /// <summary>
    /// 商品資料
    /// </summary>
    public class Product : DBEntity
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 商品名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品單價
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 商品描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 商品圖片
        /// </summary>
        public string Image { get; set; }
    }
}
