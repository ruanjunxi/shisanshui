using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMetro
{
    class CardModel
    {
        public List<TypeCard> typeCardList;

        public CardModel()
        {
            typeCardList = new List<TypeCard>();
        }
    }
    /// <summary>
    /// 牌型
    /// </summary>
    public enum DeckTypeEnum : byte
    {
        /// <summary>
        /// 未识别
        /// </summary>
        Error = 255,
        /// <summary>
        /// 过牌为空
        /// </summary>
        None = 0,
        /// <summary>
        /// 高牌-散牌-乌龙1
        /// </summary>
        Single,
        /// <summary>
        /// 对子2
        /// </summary>
        Double,
        /// <summary>
        /// 两对3
        /// </summary>
        TwoDouble,
        /// <summary>
        /// 三张4
        /// </summary>
        Three,
        /// <summary>
        /// 顺子5
        /// </summary>
        ShunZi,
        /// <summary>
        /// 同花6
        /// </summary>
        TongHua,
        /// <summary>
        /// 葫芦7
        /// </summary>
        Gourd,
        /// <summary>
        /// 炸弹8
        /// </summary>
        Bomb,
        /// <summary>
        /// 同花顺9
        /// </summary>
        TongHuaShun,
        /// <summary>
        /// 五炸10
        /// </summary>
        FiveBomb
    }

    public class TypeCard
    {
        public DeckTypeEnum cardType;//牌型
        public List<int> cardList;//手牌
    }

}
