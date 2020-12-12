﻿using UnityEngine;
public class RandomLogin : MonoBehaviour
{ 
    #region 名字
    public string[] girlNames = { "艾比盖尔", "艾达", "爱得拉", "爱得莱德", "阿芙拉", "爱葛莎", "爱葛妮丝", "爱尔柏塔", "亚莉克希亚", "爱丽丝", "爱玛", "阿尔娃", "阿曼达", "阿蜜莉雅", "艾咪", "安娜塔西雅", "安德莉亚", "安琪拉", "安妮", "安娜", "安娜贝儿", "安东妮儿", "艾谱莉", "艾琳娜", "艾丝翠得", "雅典娜", "奥德莉", "奥萝拉", "芭芭拉", "碧翠丝", "贝琳达", "贝拉", "柏妮丝", "柏莎", "百丽儿", "贝丝", "贝琪", "贝蒂", "贝芙丽", "布兰琪", "布莱兹", "邦妮", "布丽姬特", "卡蜜拉", "坎蒂丝", "卡拉", "卡萝", "卡洛琳", "凯瑟琳", "凯丝", "塞西莉亚", "莎莉丝特", "夏洛特", "绮莉", "绮丽儿", "克洛怡", "克莉丝汀", "克莱儿", "克莱拉", "康斯坦丝", "柯拉", "卡洛儿", "可妮莉雅", "克莉斯多", "辛西亚", "黛西", "黛儿", "黛娜", "黛芙妮", "达莲娜", "潼恩", "黛碧", "黛博拉", "迪得莉", "迪丽雅", "丹尼丝", "黛安娜", "多洛莉丝", "多明尼卡", "唐娜", "多拉", "多琳", "多莉丝", "桃乐斯", "尔莎", "伊甸", "伊蒂丝", "艾德文娜", "爱琳", "伊莲恩", "艾琳诺", "伊莉莎白", "艾尔玛", "艾西", "艾薇拉", "艾蜜莉", "艾玛", "伊妮德", "艾丽卡", "艾琳", "艾丝特", "艾瑟儿", "尤朵拉", "尤妮丝", "伊文捷琳", "伊芙", "伊芙琳", "费滋", "费怡", "弗罗拉", "弗罗伦丝", "法兰西斯", "弗莉达", "菲蕾德翠卡", "嘉比里拉", "盖尔", "姬玛", "珍妮芙", "乔治亚", "娇拉汀", "姬儿", "葛莱蒂丝", "葛罗瑞亚", "葛瑞丝", "葛莉谢尔达", "葛佳丝塔芙", "关德琳", "汉娜", "哈莉特", "海柔尔", "赫达", "赫蒂", "海伦", "海洛伊丝", "何蒙莎", "希尔达", "希拉瑞莉", "汉妮", "胡达", "英格丽", "爱莉丝", "伊莎蓓尔", "艾薇", "贾桂琳", "婕咪", "珍", "珍妮特", "珍尼丝", "琴", "珍尼佛", "珍妮", "婕西", "杰西嘉", "乔", "琼", "乔安娜", "希伯来", "贾思琳", "乔蒂", "约瑟芬", "乔伊", "乔伊丝", "朱蒂斯", "朱蒂", "朱丽亚", "朱莉", "朱丽叶", "朱恩", "卡玛", "凯伦", "凯伊", "凯莉盖", "金百莉", "吉蒂", "萝拉", "萝瑞尔", "萝伦", "莉拉", "李奥娜", "雷思丽", "莉蒂西雅", "莉莉斯", "丽莲", "琳达", "琳赛", "丽莎", "莉斯", "洛伦", "璐易丝", "露西", "莉蒂亚", "琳", "玛佩尔", "玛德琳", "玛琪", "玛姬", "梅蜜", "曼蒂", "玛西亚", "玛格丽特", "玛丽亚", "玛丽安", "马丽娜", "玛乔丽", "玛莎", "玛蒂娜", "玛丽", "穆得", "穆琳", "梅薇思", "玛可欣", "麦格", "梅", "梅根", "蒙丽莎", "玛希", "梅莉", "蜜雪儿", "蜜雪莉雅", "蜜妮安", "穆得莉", "蜜拉贝儿", "米兰达", "蜜莉恩", "摩黛丝提", "茉伊拉", "茉莉", "梦娜", "莫妮卡", "穆丽儿", "玛拉", "蜜尔娜", "南茜", "娜特莉", "娜提雅维达", "内丽", "妮可拉", "妮可", "妮娜", "诺拉", "诺玛", "诺维雅", "妮蒂亚", "奥克塔薇尔", "奥蒂列特", "奥蒂莉亚", "欧尔佳", "奥丽芙", "奥丽薇亚", "奥菲莉亚", "佩格", "蓓姬", "潘蜜拉", "潘朵拉", "派翠西亚", "赛拉", "佩儿", "潘娜洛普", "潘妮", "菲碧", "菲妮克丝", "菲丽丝", "珀莉", "波比", "普莉玛", "普鲁登斯", "昆娜", "昆蒂娜", "瑞琪儿", "瑞伊", "丽蓓卡", "蕾佳娜", "蕾娜塔", "蕾妮", "莉达", "莉娃", "萝勃塔", "罗莎琳德", "罗丝", "露丝玛丽", "洛葛仙妮", "露比", "露丝", "莎碧娜", "莎莉", "莎柏琳娜", "莎洛姆", "莎曼撤", "珊朵拉", "仙蒂", "莎拉", "莎芭丝提妮", "萨琳娜", "雪伦", "希拉", "雪莉", "雪丽", "希贝儿", "西格莉德", "席梦娜", "苏菲亚", "丝柏凌", "史黛丝", "丝特勒", "丝特芬妮", "苏珊", "苏珊娜", "苏西", "西维亚", "泰贝莎", "泰蜜", "泰瑞莎", "泰丝", "席拉", "泰丽莎", "蒂芙妮", "蒂娜", "托比", "翠西", "翠丝特", "杜达", "优拉", "优娜", "耳舒拉", "范伦汀娜", "瓦勒莉", "瓦妮莎", "维纳斯", "维拉", "维娜", "维隆卡", "维拉妮卡", "维多利亚", "维琪", "维尔拉", "维尔莉特", "维吉妮亚", "维达", "维文", "华莉丝", "旺妲", "温蒂", "温妮费德", "温妮", "桑席", "赛薇亚拉", "芝妮雅", "耶达", "依耶塔", "依耶芙特", "伊芳", "丽诺比丽", "若伊", "若娜", "若拉", "阿比盖尔", "艾比", "阿德莱德", "艾德琳", "亚历桑德拉", "艾丽莎", "艾米", "亚历克西斯", "艾丽西娅", "艾莉森", "艾莉莎", "爱丽丝娅", "艾美", "安伯", "阿纳斯塔西娅", "安琪", "安吉拉", "安吉莉亚", "安吉莉娜", "安", "安尼塔", "艾莉尔", "阿普里尔", "阿什利", "欧蕊", "阿维娃", "笆笆拉", "芭比", "贝亚特", "比阿特丽斯", "贝基", "贝斯", "布兰奇", "布伦达", "布莱安娜", "布兰妮", "布列塔尼", "卡米尔", "莰蒂丝", "坎蒂", "卡瑞娜", "卡门", "凯罗尔", "卡罗琳", "凯丽", "凯莉", "卡桑德拉", "凯西", "凯茜", "切尔西", "沙琳", "切莉", "雪莉尔", "克洛伊", "克莉丝", "克里斯蒂娜", "克里斯汀", "克里斯蒂", "辛迪", "克莱尔", "克劳迪娅", "克莱门特", "克劳瑞丝", "康妮", "康斯坦斯", "科拉", "科瑞恩", "科瑞斯特尔", "戴茜", "达芙妮", "达茜", "戴夫", "黛比", "黛布拉", "黛米", "德洛丽丝", "堂娜", "桃瑞丝", "伊迪丝", "伊迪萨", "伊莱恩", "埃莉诺", "伊丽莎白", "埃拉", "爱伦", "艾莉", "艾米瑞达", "艾米丽", "埃尔莎", "埃莉卡", "爱斯特尔", "爱丝特", "尤杜拉", "伊娃", "伊夫林", "芬妮", "菲奥纳", "福罗拉", "弗郎西丝", "弗雷德里卡", "弗里达", "吉娜", "吉莉安", "格拉蒂丝", "格罗瑞娅", "格瑞丝", "格瑞塔", "格温多琳", "海莉", "赫柏", "海伦娜", "汉纳", "海蒂", "希拉莉", "英格丽德", "伊莎贝拉", "爱沙拉", "艾丽丝", "艾维", "杰奎琳", "杰德", "詹米", "简", "贾斯敏", "姬恩", "珍娜", "詹妮弗", "詹妮", "杰西卡", "杰西", "姬尔", "乔斯林", "乔莉埃特", "乔茜", "乔伊斯", "朱迪丝", "朱莉娅", "朱莉安娜", "凯琳", "卡瑞达", "凯特", "卡蒂", "卡特里娜", "凯", "凯拉", "凯尔西", "特里娜", "基蒂", "莱瑞拉", "蕾西", "劳拉", "罗兰", "莉娜", "莉迪娅", "莉莲", "莉莉", "莉兹", "洛拉", "罗琳", "路易莎", "路易丝", "露西娅", "露茜", "露西妮", "露露", "林恩", "马德琳", "玛米", "曼达", "曼迪", "玛丽莲", "梅维丝", "玛蒂尔达", "莫琳", "玛克辛", "梅米", "梅甘", "梅琳达", "梅利莎", "美洛蒂", "默西迪丝", "梅瑞狄斯", "米娅", "米歇尔", "米莉", "米里亚姆", "莫尼卡", "摩尔根", "娜塔莉", "娜塔莎", "尼基塔", "尼娜", "拉/诺拉", "尼迪亚", "奥克塔维亚", "奥琳娜", "奥利维亚", "奥菲莉娅", "奥帕", "帕梅拉", "帕特丽夏", "芭迪", "保拉", "波琳", "珀尔", "帕姬", "菲洛米娜", "菲比", "波莉", "普里西拉", "雷切尔", "丽贝卡", "瑞加娜", "丽塔", "洛克萨妮", "萨布丽娜", "萨莉", "桑德拉", "萨曼莎", "萨米", "桑迪", "萨瓦娜", "斯嘉丽", "塞尔玛", "塞琳娜", "塞丽娜", "莎伦", "斯莱瑞", "西尔维亚", "索尼亚", "索菲娅", "丝塔茜", "丝特拉", "斯蒂芬妮", "苏", "萨妮", "塔玛拉", "苔米", "坦尼娅", "塔莎", "特莉萨", "苔丝", "蒂凡妮", "棠雅", "特蕾西", "厄休拉", "温妮莎", "维姬", "薇薇安", "旺达", "惠特尼", "韦恩", "尤兰达", "伊薇特", "伊温妮", "塞尔达", "佐伊", "卓拉", "梅尔维纳", "爱莲娜", "艾连娜", "悠悠", "幽幽", "玛丽娜", "米西迪亚", "米希迪雅", "萝贝塔", "卡多莉", "碧翠克斯", "卡恋", "切尔莉", "翡丽安娜" };
      
      public string[] boyNames = { "亚伦", "亚伯", "亚伯拉罕", "亚当", "艾德里安", "艾登", "阿尔瓦", "埃里克斯", "亚历山大", "艾伦", "艾伯特", "阿尔弗雷德", "安德鲁", "安迪", "安格斯", "安东尼", "阿波罗", "阿诺德", "亚瑟", "奥古斯特", "奥斯汀", "本杰明", "伯特", "本森", "比尔", "比利", "布莱克", "鲍伯", "鲍比", "布拉德", "布兰登", "布兰特", "布伦特", "布赖恩", "布朗", "布鲁斯", "迦勒", "卡梅伦", "卡尔", "卡洛斯", "凯里", "卡斯帕", "塞西", "查尔斯", "采尼", "克里斯", "克里斯蒂安", "克里斯多夫", "克拉克", "柯利弗", "科迪", "科尔", "科林", "科兹莫", "丹尼尔", "丹尼", "达尔文", "大卫", "丹尼斯", "德里克", "狄克", "唐纳德", "道格拉斯", "杜克", "迪伦", "埃迪", "埃德加", "爱迪生", "艾德蒙", "爱德华", "艾德文", "以利亚", "艾略特", "埃尔维斯", "埃里克", "伊桑", "尤金", "埃文", "福特", "弗兰克思", "弗兰克", "富兰克林", "弗瑞德", "加百利", "加比", "加菲尔德", "加里", "加文", "杰弗里", "乔治", "基诺", "格林", "格林顿", "汉克", "哈帝", "哈里森", "哈利", "海顿", "亨利", "希尔顿", "雨果", "霍华德", "伊恩", "伊格纳缇", "伊凡", "艾萨克", "艾塞亚", "杰克", "杰克逊", "雅各布", "詹姆士", "詹森", "杰伊", "杰弗瑞", "杰罗姆", "杰瑞", "杰西", "吉姆", "吉米", "乔", "约翰", "约翰尼", "乔纳森", "乔丹", "约瑟夫", "约书亚", "贾斯汀", "凯斯", "肯", "肯尼迪", "肯尼斯", "肯尼", "凯文", "凯尔", "兰斯", "拉里", "劳伦特", "劳伦斯", "利安德尔", "李", "雷欧", "雷纳德", "利奥波特", "莱斯利", "劳伦", "劳瑞", "劳瑞恩", "路易斯", "卢克", "马库斯", "马西", "马克", "马科斯", "马尔斯", "马歇尔", "马丁", "马文", "梅森", "马修", "马克斯", "迈克尔", "米奇", "麦克", "纳撒尼尔", "尼尔", "尼尔森", "尼古拉斯", "尼克", "诺亚", "诺曼", "奥利弗", "奥斯卡", "欧文", "帕特里克", "保罗", "彼得", "菲利普", "菲比", "昆廷", "兰德尔", "伦道夫", "兰迪", "雷", "罗兰德", "列得", "雷克斯", "理查德", "里奇", "莱利", "罗伯特", "罗宾", "罗宾逊", "洛克", "罗杰", "罗纳德", "罗文", "罗伊", "赖安", "山姆", "萨米", "塞缪尔", "斯考特", "肖恩", "西德尼", "西蒙", "所罗门", "斯帕克", "斯宾塞", "斯派克", "斯坦利", "史蒂夫", "史蒂文", "斯图尔特", "斯图亚特", "特伦斯", "特里", "泰德", "托马斯", "提姆", "蒂莫西", "托德", "汤米", "汤姆", "托尼", "泰勒", "奥特曼", "尤利塞斯", "范", "弗恩", "弗农", "维克多", "文森特", "华纳", "沃伦", "韦恩", "卫斯理", "威廉", "威利", "扎克", "圣扎迦利", "凯恩", "伊欧", "汤玛士", "基尔", "阿鲁贝尔特", "瓦格曼", "克雷格", "伊夫拉姆", "伊扎亚", "梅拉希姆" };
    #endregion
}