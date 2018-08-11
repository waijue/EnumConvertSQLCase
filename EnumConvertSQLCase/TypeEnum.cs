using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConvertSQLCase
{
    public enum StockChangeType
    {
       

        /// <summary>
        /// 盘点
        /// </summary>
        [Description("盘点")]
        Check = 1,
        /// <summary>
        /// 还原库存
        /// </summary>
        [Description("还原库存")]
        RestoreStock = 2,
        /// <summary>
        /// 订单转滞留
        /// </summary>
        [Description("订单转滞留")]
        OrderInHeldUp = 3,
        /// <summary>
        /// 订单锁定
        /// </summary>
        [Description("订单锁定")]
        OrderLock = 4,
        /// <summary>
        /// 订单锁定
        /// </summary>
        [Description("订单解锁")]
        OrderUnLock = 5,
        /// <summary>
        /// 订单产品更新
        /// </summary>
        [Description("订单产品更新")]
        OrderProductUpdate = 6,
        /// <summary>
        /// 采购
        /// </summary>
        [Description("采购")]
        Purchase = 7,
        /// <summary>
        /// 调拨删除
        /// </summary>
        [Description("调拨删除")]
        ShiftDelete = 8,
        /// <summary>
        /// 调拨修改
        /// </summary>
        [Description("调拨修改")]
        ShiftEdit = 9,
        /// <summary>
        /// 调拨入库
        /// </summary>
        [Description("调拨入库")]
        ShiftInStore = 10,
        /// <summary>
        /// 调拨锁定
        /// </summary>
        [Description("调拨锁定")]
        ShiftLock = 11,
        /// <summary>
        /// 调拨出库
        /// </summary>
        [Description("调拨出库")]
        ShiftOutStore = 12,
        /// <summary>
        /// 发货扣除
        /// </summary>
        [Description("发货扣除")]
        Shiped = 13,
        /// <summary>
        /// 返修入库
        /// </summary>
        [Description("返修入库")]
        RepairInStore = 14,
        /// <summary>
        /// 返修锁定
        /// </summary>
        [Description("返修锁定")]
        REPAIRLOCK = 15,
        /// <summary>
        /// 返修删除解除锁定
        /// </summary>
        [Description("返修删除解除锁定")]
        RepairUnlock = 16,
        /// <summary>
        /// 返修出库
        /// </summary>
        [Description("返修出库")]
        RepairOutStore = 17,
        /// <summary>
        /// 清货报损出库
        /// </summary>
        [Description("清货报损出库")]
        ReportedLossOutStore = 18,
        /// <summary>
        /// 测试锁定
        /// </summary>
        [Description("测试锁定")]
        TestLock = 19,
        /// <summary>
        /// 测试入库
        /// </summary>
        [Description("测试入库")]
        TestInStore = 20,
        /// <summary>
        /// 测试出库
        /// </summary>
        [Description("测试出库")]
        TestOutStore = 21,
        /// <summary>
        /// 测试删除解除锁定
        /// </summary>
        [Description("测试删除解除锁定")]
        TestUnlock = 22,
        /// <summary>
        /// 修改为需要测试
        /// </summary>
        [Description("修改为需要测试")]
        ToTest = 23,
        /// <summary>
        /// 修改为不需要测试
        /// </summary>
        [Description("修改为不需要测试")]
        ToNotTest = 24,
        /// <summary>
        /// 退货入库
        /// </summary>
        [Description("退货入库")]
        ReturnInStore = 25,
        /// <summary>
        /// 无返修单入库
        /// </summary>
        [Description("无返修单入库")]
        NoRepairInStore = 26,
        /// <summary>
        /// 其它入库
        /// </summary>
        [Description("其它入库")]
        OtherInStore = 27,
        /// <summary>
        /// ta产品直接入库
        /// </summary>
        [Description("产品直接入库")]
        TAProductInStore = 28,
        /// <summary>
        /// ta入库单入库
        /// </summary>
        [Description("入库单入库")]
        TAProductStockListInStore = 29,
        /// <summary>
        /// 产品领用
        /// </summary>
        [Description("产品领用")]
        SellOutStore = 30,
        /// <summary>
        /// 货物报损出库
        /// </summary>
        [Description("货物报损出库")]
        DamageOutStore = 31,
        /// <summary>
        /// 其它出库
        /// </summary>
        [Description("其它出库")]
        OtherOutStore = 32,
        /// <summary>
        /// 取消出入库
        /// </summary>
        [Description("取消出入库")]
        CancelInOutStore = 33,
        /// <summary>
        /// 退件直接返修入库
        /// </summary>
        [Description("退件直接返修入库")]
        BackRepairItemInStore = 34,
        /// <summary>
        /// 销售单
        /// </summary>
        [Description("销售单")]
        SalesSing = 35,
        /// <summary>
        /// 删除销售单
        /// </summary>
        [Description("删除销售单")]
        DeleteSalesSing = 36,
        /// <summary>
        /// 销售出库
        /// </summary>
        [Description("销售出库")]
        OutSalesSing = 37,
        /// <summary>
        /// 报损单
        /// </summary>
        [Description("报损单")]
        LostBill = 38,
        /// <summary>
        /// 删除报损单
        /// </summary>
        [Description("删除报损单")]
        DeleteLostBill = 39,
        /// <summary>
        /// 报损出库
        /// </summary>
        [Description("报损出库")]
        OutLostBill = 40,

        /// <summary>
        /// 产品组合入库
        /// </summary>
        [Description("产品组合入库")]
        PMXInStore = 41,

        /// <summary>
        /// 产品组合时子产品出库
        /// </summary>
        [Description("产品组合时子产品出库")]
        PMXOutStore = 42,

        /// <summary>
        /// 产品组拆分出库
        /// </summary>
        [Description("产品组拆分出库")]
        PMXSeparateOutStore = 43,

        /// <summary>
        /// 产品组拆分时子产品入库
        /// </summary>
        [Description("产品组拆分时子产品入库")]
        PMXSeparateInStore = 44,
        /// <summary>
        /// 盘点修改状态
        /// </summary>
        [Description("盘点修改状态")]
        StockStateChange = 45,

        /// <summary>
        /// 系统盘点
        /// </summary>
        [Description("系统盘点")]
        AutoCheck = 46,

        /// <summary>
        /// 撤消
        /// </summary>
        [Description("撤消")]
        Cancel = 47,

        /// <summary>
        ///  包装材料领取
        /// </summary>
        [Description("包装材料领取")]
        PackagingMaterialsTake = 48,

        /// <summary>
        /// 发货配货返还
        /// </summary>
        [Description("发货配货返还")]
        BackInStore_Shiped = 49,

        /// <summary>
        /// 调拨配货返还
        /// </summary>
        [Description("调拨配货返还")]
        BackInStore_Shift = 50,

        /// <summary>
        /// 等待发货
        /// </summary>
        [Description("等待发货")]
        ShipedWaiting = 51,

        /// <summary>
        /// 等待发货返还
        /// </summary>
        [Description("等待发货返还")]
        ShipedWaiting_Return = 52,

        /// <summary>
        /// 移架盘点
        /// </summary>
        [Description("移架盘点")]
        MoveRackCheck = 53,

        /// <summary>
        /// 添加货位
        /// </summary>
        [Description("添加货位")]
        AddRack = 54,
        /// <summary>
        /// 同步库存
        /// </summary>
        [Description("同步库存")]
        SyncStock = 55,

        /// <summary>
        /// 采购入库撤销
        /// </summary>
        [Description("采购入库撤销")]
        PurchaseInStorageCancel = 56,

        /// <summary>
        /// 调拨撤回
        /// </summary>
        [Description("调拨撤回")]
        ReturnShift = 57,

        /// <summary>
        /// 滞销下架
        /// </summary>
        [Description("滞销下架")]
        DamageChangeStore = 58,

        /// <summary>
        /// 退件报损
        /// </summary>
        [Description("退件报损")]
        BackLostBill = 59,

        /// <summary>
        /// 设置主货架
        /// </summary>
        [Description("设置主货架")]
        SetDefaultRack = 60,

        /// <summary>
        /// 移除货架
        /// </summary>
        [Description("移除货架")]
        RemoveRack = 61,

        /// <summary>
        /// 样品入库
        /// </summary>
        [Description("样品入库")]
        SampleInStorage = 62,

        /// <summary>
        /// 还原等待发货库存
        /// </summary>
        [Description("还原等待发货库存")]
        ReductionShippingWait = 63,

        /// <summary>
        /// 调拨配货
        /// </summary>
        [Description("调拨配货")]
        ShiftWaiting = 64,

        /// <summary>
        /// 样品配货
        /// </summary>
        [Description("样品配货")]
        SampleAllocate = 65,

        /// <summary>
        /// 领用配货
        /// </summary>
        [Description("领用配货")]
        ReceiveAllocate = 66,

        /// <summary>
        /// 样品单发货扣除
        /// </summary>
        [Description("样品单发货扣除")]
        SampleShiped = 67,

        /// <summary>
        /// 领用单发货扣除
        /// </summary>
        [Description("领用单发货扣除")]
        ReceiveShiped = 68,

        /// <summary>
        /// 测试变动库存状态
        /// </summary>
        [Description("测试变动库存状态")]
        TestChangeStockStatus = 69,

        /// <summary>
        /// 多货入库
        /// </summary>
        [Description("多货入库")]
        MorePackageInStorage = 70,

        /// <summary>
        /// 撤销入库
        /// </summary>
        [Description("撤销入库")]
        ReRepairInStore = 71,

        /// <summary>
        /// 报损入库
        /// </summary>
        [Description("报损入库")]
        LostBillInStore = 72,

        /// <summary>
        /// 样品上架
        /// </summary>
        [Description("样品上架")]
        SampleInStock = 73,

        /// <summary>
        /// 发货配货还货
        /// </summary>
        [Description("发货配货还货")]
        ReturnByShiped = 74,

        /// <summary>
        /// 调拨配货还货
        /// </summary>
        [Description("调拨配货还货")]
        ReturnByShift = 75,

        /// <summary>
        /// 样品配货还货
        /// </summary>
        [Description("样品配货还货")]
        ReturnBySample = 76,

        /// <summary>
        /// 领用配货还货
        /// </summary>
        [Description("领用配货还货")]
        ReturnByReceive = 77,

        /// <summary>
        /// 产品移架
        /// </summary>
        [Description("产品移架")]
        MoveByGoods = 78,

        /// <summary>
        /// 货位移架
        /// </summary>
        [Description("货位移架")]
        MoveByRack = 79,

        /// <summary>
        /// 退件入库
        /// </summary>
        [Description("退件入库")]
        Retreats = 80,

        /// <summary>
        /// 按框配货还货
        /// </summary>
        [Description("按框配货还货")]
        ReturnPickingFN = 81,

        /// <summary>
        /// 库容入库
        /// </summary>
        [Description("库容入库")]
        StorageCapactiy = 82,

        /// <summary>
        /// 移库管理
        /// </summary>
        [Description("移库管理")]
        StorageRelocation = 83,

        /// <summary>
        /// 样品还货 = 8
        /// </summary>
        [Description("样品还货")]
        SampleReturn = 84,

        [Description("采购装箱")]
        PurchasingPacking = 85,

        /// <summary>
        /// 产品组组合入库
        /// </summary>
        //[Description("产品组组合入库")]
        //StorageGroup = 86,

       
    }

    public enum ProductStatus
    {
        /// <summary>
        /// 正常销售
        /// </summary>
        [Description("正常销售")]
        Normal = 1,

        /// <summary>
        /// 停售
        /// </summary>
        [Description("停售")]
        SaleStop = 2,

        /// <summary>
        /// 停产
        /// </summary>
        [Description("停产")]
        ShutProduction = 3,

        /// <summary>
        /// 停止使用
        /// </summary>
        [Description("停止使用")]
        StopUsing = 4,

        /// <summary>
        /// 清货
        /// </summary>
        [Description("清货")]
        ClearStock = 5,

        /// <summary>
        /// 部分清货
        /// </summary>
        [Description("部分清货")]
        ClearStockPart = 6,

        /// <summary>
        /// 完全清货
        /// </summary>
        [Description("完全清货")]
        ClearStockFull = 7,
    }
}
