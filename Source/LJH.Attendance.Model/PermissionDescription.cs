//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace LJH.Attendance.Model
//{
//    /// <summary>
//    /// 表示用户权限模块的文字描述
//    /// </summary>
//    public class PermissionDescription
//    {
//        public static string GetDescription(string catalog)
//        {
//            if (catalog == "Card") return Resource1.Permission_Catalog_Card;
//            else if (catalog == "Data") return Resource1.Permission_Catalog_Data;
//            else if (catalog == "Hardware") return Resource1.Permission_Catalog_Hardware;
//            else if (catalog == "Report") return Resource1.Permission_Catalog_Report;
//            return string.Empty;
//        }

//        public static string GetDescription(Permission p)
//        {
//            switch (p)
//            {
//                case Permission.AddCards:
//                    return Resource1.Permission_AddCard;
//                case Permission.AlarmReport:
//                    return Resource1.Permission_AlarmReport;
//                case Permission.CardChargeReport:
//                    return Resource1.Permission_CardChargeReport;
//                case Permission.CardDeferReport:
//                    return Resource1.Permission_CardDeferReport;
//                case Permission.CardDisableEnableReport:
//                    return Resource1.Permission_CardDisableEnableReport;
//                case Permission.CardEventReport:
//                    return Resource1.Permission_CardEventReport;
//                case Permission.CardLossRestoreReport:
//                    return Resource1.Permission_CardLossRestoreReport;
//                case Permission.CardPaying:
//                    return Resource1.Permission_CardPaying;
//                case Permission.CardPayingReport:
//                    return Resource1.Permission_CardPayingReport;
//                case Permission.CardRecycleReport:
//                    return Resource1.Permission_CardRecycleReport;
//                case Permission.CardReleaseReport:
//                    return Resource1.Permission_CardReleaseReport;
//                case Permission.CarFlowStatistics:
//                    return Resource1.Permission_CarFlowStatistics;
//                case Permission.ChargeCard:
//                    return Resource1.Permission_ChargeCard;
//                case Permission.CloseDoor:
//                    return Resource1.Permission_CloseDoor;
//                case Permission.DeferCard:
//                    return Resource1.Permission_DeferCard;
//                case Permission.DisableCard:
//                    return Resource1.Permission_DisableCard;
//                case Permission.DownloadAllCards:
//                    return Resource1.Permission_DownloadAllCards;
//                case Permission.EditAPM:
//                    return Resource1.Permission_EditAPM;
//                case Permission.EditCard:
//                    return Resource1.Permission_EditCard;
//                case Permission.EditDivision:
//                    return Resource1.Permission_EditDivision;
//                case Permission.EditEntrance:
//                    return Resource1.Permission_EditEntrance;
//                case Permission.EditOperator:
//                    return Resource1.Permission_EditOperator;
//                case Permission.EditPark:
//                    return Resource1.Permission_EditPark;
//                case Permission.EditRole:
//                    return Resource1.Permission_EditRole;
//                case Permission.EditSysSetting:
//                    return Resource1.Permission_EditSysSetting;
//                case Permission.EditVideo:
//                    return Resource1.Permission_EditVideo;
//                case Permission.EditWorkstation:
//                    return Resource1.Permission_EditWorkstation;
//                case Permission.EnableCard:
//                    return Resource1.Permission_EnableCard;
//                case Permission.ExportCardPayment:
//                    return Resource1.Permission_ExportCardPayment;
//                case Permission.ExportMonthCardPaymentReport:
//                    return Resource1.Permission_ExportMonthCardPaymentReport;
//                case Permission.LostCard:
//                    return Resource1.Permission_LostCard;
//                case Permission.ModifyCardPaymentRecord:
//                    return Resource1.Permission_ModifyCardPaymentRecord;
//                case Permission.OpenDoor:
//                    return Resource1.Permission_OpenDoor;
//                case Permission.OperatorShiftStatistics:
//                    return Resource1.Permission_OperatorShiftStatistics;
//                case Permission.PayOperationLogReport:
//                    return Resource1.Permission_PayOperationLogReport;
//                case  Permission.CardInparkReport :
//                    return Resource1.Permission_CardInParkReport;
//                case Permission.ReadAPM:
//                    return Resource1.Permission_ReadAPM;
//                case Permission.ReadCards:
//                    return Resource1.Permission_ReadCard;
//                case Permission.ReadOperaotor:
//                    return Resource1.Permission_ReadOperator;
//                case Permission.ReadRole:
//                    return Resource1.Permission_ReadRole;
//                case Permission.ReadSysSetting:
//                    return Resource1.Permission_ReadSysSetting;
//                case Permission.ReadWorkstation:
//                    return Resource1.Permission_ReadWorkstation;
//                case Permission.RecycleCard:
//                    return Resource1.Permission_RecycleCard;
//                case Permission.ReleaseCard:
//                    return Resource1.Permission_ReleaseCard;
//                case Permission.RemoteReadCard:
//                    return Resource1.Permission_RemoteReadCard;
//                case Permission.ResetEntrance:
//                    return Resource1.Permission_ResetDevice;
//                case Permission.RestoreCard:
//                    return Resource1.Permission_RestoreCard;
//                case Permission.SystemIDSetting:
//                    return Resource1.Permission_SystemIDSetting;
//                case Permission.TempCardSetting:
//                    return Resource1.Permission_TempCardSetting;
//                case Permission.VideoMonitor:
//                    return Resource1.Permission_VideoMonitor;
//                case Permission .OperatorSettle :
//                    return Resource1.Permission_OperatorSettle;
//                case Permission.OtherOperatorSettle :
//                    return Resource1.Permission_OtherOperatorSettle;
//                case Permission .CardDeferStatistics :
//                    return Resource1.Permission_CardDeferStatistic;
//                case  Permission.CardPayingStatistics :
//                    return Resource1.Permission_CardPayingStatistic;
//                case Permission.RealEvent :
//                    return Resource1.Permission_RealEvent;
//                case Permission .PrintOperatorSettleLog :
//                    return Resource1.Permission_PrintOperatorSettleLog;
//                case Permission .CardDeleteReport :
//                    return Resource1.Permission_CardDeleteReport;
//                case Permission .PrintCardPayment :
//                    return Resource1.Permission_PrintCardPayment;
//                case  Permission.PrintMonthCardPaymentReport :
//                    return Resource1.Permission_PrintMonthCardPaymentReport;
//                case Permission .CardIDConvert :
//                    return Resource1.Permission_CardIDConvert;
//                case Permission .CardBulkChange :
//                    return Resource1.Permission_BulkChangeCards;
//                case  Permission.ExportCards :
//                    return Resource1.Permission_ExportCards;
//                case Permission .ZSTSetting :
//                    return Resource1.Permission_ZSTSeting;
//                case Permission .YangChenTongLogReport :
//                    return Resource1.Permission_YangChenTongLogReport;
//                case Permission.SyncDataToStandby:
//                    return Resource1.Permission_SyncDataToStandby;
//                case Permission.AddManageCard:
//                    return Resource1.Permission_AddManageCard;
//                case Permission.ChangeCardKey:
//                    return Resource1.Permission_ChangeCardKey;
//                case Permission.CardDataConvert:
//                    return Resource1.Permission_CardDataConvert;
//                default:
//                    return string.Empty;
//            }
//        }
//    }
//}
