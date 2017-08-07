using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEDU.SQLiteDB.Tables;

#region Created by Balaraju

namespace MEDU.SQLiteDB.Connection
{
	public interface IDatabaseMethods
	{
		#region DeviceToekn Methods

		void SaveDeviceToken(string deviceToken, string deviceUDID);
		DeviceTokenInfo GetDeviceToken();

		#endregion

		//#region UserInfo Methods

		//void SaveUserInfo(UserLoginInfo objUserInfo);
		//UserLoginInfo GetUserInfo();
		//void UpdateUserInfo(UserLoginInfo objUserInfo);
		//void DeleteUserInfo();

		//#endregion


		//#region UserProfileInfo Methods

		//void SaveUserProfileInfo(UserLoginProfile objUserProfileInfo);
		//UserLoginProfile GetUserProfileInfo();
		//void UpdateUserProfileInfo(UserLoginProfile objUserProfileInfo);
		//void DeleteUserProfileInfo();

		//#endregion


		//#region DomainInfo Methods

		//void SaveDomainInfo(List<AdminDomainInfo> objUserInfo);
		//List<DomainInfo> GetDomainInfo();
		//void UpdateDomainInfo(List<AdminDomainInfo> objUserInfo);
		//void DeleteDomainInfo();
		//#endregion

		//#region QRCodeInfo Methods

		//void SaveQRCodeInfo(QRCodeInfo objUserInfo);
		//QRCodeInfo GetQRCodeInfo();
		//void UpdateQRCodeInfo(QRCodeInfo objUserInfo);
		//void DeleteQRCodeInfo();

		//#endregion

		//#region StoreInfo Methods

		//void SaveStoreInfo(Storeinfo objUserInfo);
		//Storeinfo GetStoreInfo();
		//void UpdateStoreInfo(Storeinfo objUserInfo);
		//void DeleteStoreInfo();

		//#endregion


		//#region MesuringUnitsInfo Methods

		//void SaveMesuringUnitsInfo(List<MeasuringUnitsListInfo> objUserInfo);
		//List<MesuringUnitsInfo> GetMesuringUnitsInfo();
		//void UpdateMesuringUnitsInfo(List<MeasuringUnitsListInfo> objUserInfo);
		//void DeleteMesuringUnitsInfo();

		//#endregion
	}
}

#endregion