# Namespace Journey.SurfaceWater
[更新记录](https://github.com/sm1lewc/Journey.SurfaceWater/blob/master/Journey.SurfaceWater/%E6%9B%B4%E6%96%B0%E8%AF%B4%E6%98%8E.md)<br>
**考虑到数据修约等问题，把所有浓度值均调整为decimal类型**<br>
**新增方法均通过单元测试**
# 1 Journey.SurfaceWater.Enums 定义的枚举
## 1.1 Factor 监测指标  
没有完全延续总站以往的规定，稍微改动了,去掉"-"、"_"符号并全部大写，主要是为了方便编码。  

|单词/简写|说明|编码||单词/简写|说明|编码|
|:-------------:|:--------------:|:-----------------------:|:-------------:||:--------------:|:-----------------------:|
|EC|电导率|w01014||TRICHLOROMETHANE|三氯甲烷|W24004|
|NTU|浊度|w01003||TETRACHLOROMETHANE|四氯化碳_四氯甲烷|W24005|
|WT|水温|w01010||TRIBROMOMETHANE|三溴甲烷|W24009|
|PH|pH|w01001||DCM|二氯甲烷|W24003|
|DO|溶解氧|w01009||DICHLOROETHANE|一_二_二氯乙烷|W24017|
|CODMN|高锰酸盐指数|w01019||ECH|环氧氯丙烷|W24024|
|COD|化学需氧量|w01018||VCM|氯乙烯|W24046|
|BOD5|五日生化需氧量|w01017||11DCE|一_一_二氯乙烯|W24047|
|NH3N|氨氮|w21003||12DCE|一_二_二氯乙烯|W24048|
|TP|总磷|w21011||TCE|三氯乙烯|W24049|
|TN|总氮|w21001||PCE|四氯乙烯|W24050|
|CU|铜|w20122||CHLOROPRENE|氯丁二烯|W24062|
|ZN|锌|w20123||HCBD|六氯丁二烯|W24064|
|F|氟化物|w21017||STYRENE|苯乙烯|W25038|
|SE|硒|w20128||FORMALDEHYDE|甲醛|W31001|
|AS|砷|w20141||ACETALDEHYDE|乙醛|W31002|
|HG|汞|w20111||ACROLEIN|丙烯醛|W31004|
|CD|镉|w20115||CHLORAL|三氯乙醛|W31003|
|CR6|六价铬|w20117||PHH|苯|W25002|
|PB|铅|w20120||TOLUENE|甲苯|W25003|
|CN|氰化物|w21016||XYLENE|二甲苯|W25005|
|PHEN|挥发酚|w23002||IBP|异丙苯|W25034|
|TPH|石油类|w22001||PHCL|氯苯|W25010|
|LAS|阴离子表面活性剂|w19002||12DCB|一_二_二氯苯|W25011|
|H2S|硫化物|w21019||14DCB|一_四_二氯苯|W25013|
|FC|粪大肠菌群|w02003||TRICHLOROBENZENE|三氯苯|W25014|
|SO42|硫酸盐|w21038||CCL4C6H4|四氯苯|W25016|
|CL|氯化物|w21022||HEXACHLOROBENZENE|六氯苯|W25019|
|NO3|硝酸盐|w21007||NITROBENZENE|硝基苯|W25023|
|FE|铁|w20125||C6H4O2N2|二硝基苯|W25027|
|MN|锰|w20124||DINITROTOLUENE|二_四_二硝基甲苯|W25030|
|MO|钼|w20061||TNT|二_四_六_三硝基甲苯|W25032|
|CO|钴|w20038||CHLORONITROBENZENE|硝基氯苯|W25020|
|BE|铍|w20127||CLC6H3NO22|二_四_二硝基氯苯|W25022|
|B|硼|w20023||CL2C6H4OH|二_四_二氯苯酚|W23020|
|SB|锑|w20004||CL3C6H3OH|二_四_六_三氯苯酚|W23022|
|NI|镍|w20121||CL5C6H3OH|五氯酚|W23025|
|BA|钡|w20012||ANILINE|苯胺|W26001|
|V|钒|w20101||C6H5NH2|联苯胺|W26002|
|TI|钛|w20095||AM|丙烯酰胺|W26048|
|TL|铊|w20089||ACRYLONITRILE|丙烯腈|W99010|
|TC|透明度|w01004||DIBUTYL_PHTHALATE|邻苯二甲酸二丁酯|W29002|
|CHLA|叶绿素a|w01016||DEHP|邻苯二甲酸二_二_乙基己基_酯|W29004
|C|藻密度|w19011|

## 1.2 Waterbody 水体类型  
主要是为了在计算总磷的相关业务中使用，目前仅使用 河流/湖库，其他枚举返回Null。

## 1.3 WaterGrade 水质类别
|类别文本|类别值|
|:-------------:|:--------------:|
|Ⅰ|1|
|Ⅱ|2|
|Ⅲ|3|
|Ⅳ|4|
|Ⅴ|5|
|劣Ⅴ|6|
# 2 Journey.SurfaceWater.EQSFSW 地表水环境质量标准
## 2.1 V2002.GradeService 水质类别的相关计算
|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|GetFactorGradeByAbbreviation|根据监测指标的简写计算指标的类别|(int,string)? eg. (4,Ⅳ)|
|GetFactorGradeByCode|根据监测指标的编码计算指标的类别|(int,string)?  eg. (4,Ⅳ)|
|Get{监测指标}Grade|计算监测指标的类别|(int,string)?  eg. (4,Ⅳ)|
|GetWaterGrade|计算整条数据的水质类别|`Models.V2002.BasicItemValuesAndGrades`|
## 2.2 V2002.StandardLimitService 标准限值的相关计算
|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|GetPHLimit|获取PH的标准限值范围|(6,9)|
|Get{监测指标}Limits|获取监测指标Ⅰ-Ⅴ类标准限值|List\<StandardLimit\>|
|Get{监测指标}LimitByGrade|获取监测指标某一类别的标准限值|double?|
|GetFactorLimitByGradeAndFactor|根据指标的简写或者代码获取类别的标准限值<br>Get{监测指标}LimitByGrade方法的集中入口，不区分大小写|double?|
# 3 Journey.SurfaceWater.Factors 监测指标
## 3.1 FactorService 监测指标的相关计算
提供偷懒的方法，也可以通过枚举Enums.Factor获取  

|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|GetFactorName|根据监测指标的缩写或者编码获取监测指标的名称|string?|
|GetFactorEnum|根据监测指标的缩写或者编码获取监测指标的枚举|`Enums.Factor`|
|GetFactorAbbreviationByCode|根据监测指标的编码获取监测指标的缩写|string?|
|GetFactorAbbreviationByName|根据监测指标的名称获取监测指标的缩写|string?|
|GetFactorCodeByAbbreviation|根据监测指标的缩写获取监测指标的编码|string?|
|GetFactorCodeByName|根据监测指标的名称获取监测指标的编码|string?|
# 4 Journey.SurfaceWater.Models 定义的模型
|类名|说明|
|:-------------:|:--------------:|
|V2002.BasicItemValues|GB 3838-2002《地表水环境质量标准》中表1的24个基本项目|
|V2002.BasicItemValuesAndGrades|继承BasicItemValues，增加各项指标水质类别及类别文本|
|StandardLimit|标准限值 {Grade,Limit}|
# 4 Journey.SurfaceWater.EQMDST 环境质量监测数据统计技术
## 4.1 V2020.RoundingService 数据修约

|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|GetAssessmentDecimalPlaces|根据监测指标的简写或编码获取评价数据的修约小数位数|int?|
|GetHourdataDecimalPlaces|根据监测指标的简写或编码获取小时数据的修约小数位数|int?|
|RoundingToEven|数据修约(四舍六入五成双)|double|

## 4.2 V2020.PHAverageService 计算PH值的平均值
|方法名|说明|返回值|
|:-------------:|:--------------:|:--------------:|
|CalculatePHAverage|计算PH值的平均值|decimal?|