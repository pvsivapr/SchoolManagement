using System;
using Xamarin.Forms;
using MEDU.SQLiteDB.Tables;
using SQLite.Net;

#region Created by Balaraju

namespace MEDU.SQLiteDB.Connection
{
	public class DatabaseMethods : IDatabaseMethods, IDisposable
	{
		static SQLiteConnection sqliteconnection;

		public DatabaseMethods()
		{
			#region Tables creation

			sqliteconnection = DependencyService.Get<ISQLite>().GetConnection();
			sqliteconnection.CreateTable<DeviceTokenInfo>();
			//sqliteconnection.CreateTable<UsersInfo>();
			//sqliteconnection.CreateTable<QRCodeInfo>();
			//sqliteconnection.CreateTable<DomainInfo>();
			//sqliteconnection.CreateTable<StoreInfo>();
			//sqliteconnection.CreateTable<UserProfileInfo>();
			//sqliteconnection.CreateTable<MesuringUnitsInfo>();

			#endregion
		}

		#region DeviceToken 

		public void SaveDeviceToken(string deviceToken, string deviceUDID)
		{
			try
			{
				sqliteconnection.Query<DeviceTokenInfo>("delete from DeviceTokenInfo");
				sqliteconnection.Insert(new DeviceTokenInfo
				{
					DeviceToken = deviceToken,
					DeviceUDID = deviceUDID
				});

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public DeviceTokenInfo GetDeviceToken()
		{
			return sqliteconnection.Table<DeviceTokenInfo>().FirstOrDefault();
		}

		public void DeleteDeviceTokens()
		{
			try
			{

				sqliteconnection.Query<DeviceTokenInfo>("delete from DeviceTokenInfo");
			}
			catch (Exception ex)
			{
				throw ex;

			}

		}

		#endregion

		//#region  UserInfo

		//public void SaveUserInfo(UserLoginInfo objUserInfo)
		//{
		//	try
		//	{
		//		sqliteconnection.Query<UsersInfo>("delete from UsersInfo");
		//		var UserInfo = sqliteconnection.Table<UsersInfo>().Where(x => x.StatusCode == (objUserInfo.StatusCode)).FirstOrDefault();

		//		if (UserInfo == null)
		//		{

		//			sqliteconnection.Insert(new UsersInfo
		//			{
		//				StatusCode = objUserInfo.StatusCode,
		//				SuperAdmin = objUserInfo.SuperAdmin,
		//				DomainAdmin = objUserInfo.DomainAdmin,
		//				StatusMessage = objUserInfo.StatusMessage,
		//				StoreUser = objUserInfo.StoreUser,
		//				Password = objUserInfo.Password,
		//				UserName = objUserInfo.UserName
		//			});
		//		}
		//		else
		//		{
		//			UserInfo.StatusCode = objUserInfo.StatusCode;
		//			UserInfo.SuperAdmin = objUserInfo.SuperAdmin;
		//			UserInfo.DomainAdmin = objUserInfo.DomainAdmin;
		//			UserInfo.StatusMessage = objUserInfo.StatusMessage;
		//			UserInfo.StoreUser = objUserInfo.StoreUser;
		//			UserInfo.Password = objUserInfo.Password;
		//			UserInfo.UserName = objUserInfo.UserName;
		//			sqliteconnection.Update(UserInfo);
		//		}

		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//public UserLoginInfo GetUserInfo()
		//{
		//	try
		//	{

		//		var userInfo = sqliteconnection.Table<UsersInfo>().FirstOrDefault();
		//		if (userInfo != null)
		//		{

		//			UserLoginInfo objUserInfo = new UserLoginInfo()
		//			{
		//				StatusCode = userInfo.StatusCode,
		//				StatusMessage = userInfo.StatusMessage,
		//				DomainAdmin = userInfo.DomainAdmin,
		//				StoreUser = userInfo.StoreUser,
		//				SuperAdmin = userInfo.SuperAdmin,
		//				UserName = userInfo.UserName,
		//				Password = userInfo.Password
		//			};
		//			return objUserInfo;
		//		}
		//		else
		//		{
		//			return null;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}

		//public void UpdateUserInfo(UserLoginInfo objUserInfo)
		//{
		//	var UserInfo = sqliteconnection.Table<UsersInfo>().FirstOrDefault();

		//	UserInfo.DomainAdmin = objUserInfo.DomainAdmin;
		//	UserInfo.StatusCode = objUserInfo.StatusCode;
		//	UserInfo.StatusMessage = objUserInfo.StatusMessage;
		//	UserInfo.StoreUser = objUserInfo.StoreUser;
		//	UserInfo.SuperAdmin = objUserInfo.SuperAdmin;
		//	UserInfo.Password = objUserInfo.Password;
		//	UserInfo.UserName = objUserInfo.UserName; ;
		//	sqliteconnection.Update(UserInfo);
		//}

		//public void DeleteUserInfo()
		//{
		//	try
		//	{

		//		sqliteconnection.Query<UserLoginInfo>("delete from UsersInfo");
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//#endregion

		//#region  UserProfileInfo

		//public void SaveUserProfileInfo(UserLoginProfile objUserProfileInfo)
		//{
		//	try
		//	{
		//		sqliteconnection.Query<UserProfileInfo>("delete from UserProfileInfo");
		//		var userProfileInfo = sqliteconnection.Table<UserProfileInfo>().Where(x => x.Id == (objUserProfileInfo.Id)).FirstOrDefault();

		//		if (userProfileInfo == null)
		//		{

		//			sqliteconnection.Insert(new UserProfileInfo
		//			{
		//				Id = objUserProfileInfo.Id,
		//				Address1 = objUserProfileInfo.Address1,
		//				Address2 = objUserProfileInfo.Address2,
		//				City = objUserProfileInfo.City,
		//				Country = objUserProfileInfo.Country,
		//				EmailAddress = objUserProfileInfo.EmailAddress,
		//				Name = objUserProfileInfo.Name,
		//				State = objUserProfileInfo.State,
		//				ZipCode = objUserProfileInfo.ZipCode,
		//				imgProfileData = objUserProfileInfo.imgProfileData
		//			});
		//		}
		//		else
		//		{
		//			userProfileInfo.Id = objUserProfileInfo.Id;
		//			userProfileInfo.Address1 = objUserProfileInfo.Address1;
		//			userProfileInfo.Address2 = objUserProfileInfo.Address2;
		//			userProfileInfo.City = objUserProfileInfo.City;
		//			userProfileInfo.Country = objUserProfileInfo.Country;
		//			userProfileInfo.EmailAddress = objUserProfileInfo.EmailAddress;
		//			userProfileInfo.Name = objUserProfileInfo.Name;
		//			userProfileInfo.State = objUserProfileInfo.State;
		//			userProfileInfo.ZipCode = objUserProfileInfo.ZipCode;
		//			userProfileInfo.imgProfileData = objUserProfileInfo.imgProfileData;
		//			sqliteconnection.Update(userProfileInfo);
		//		}

		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//public UserLoginProfile GetUserProfileInfo()
		//{
		//	try
		//	{
		//		var objUserProfileInfo = sqliteconnection.Table<UserProfileInfo>().FirstOrDefault();
		//		if (objUserProfileInfo != null)
		//		{

		//			UserLoginProfile objUserInfo = new UserLoginProfile()
		//			{
		//				Id = objUserProfileInfo.Id,
		//				Address1 = objUserProfileInfo.Address1,
		//				Address2 = objUserProfileInfo.Address2,
		//				City = objUserProfileInfo.City,
		//				Country = objUserProfileInfo.Country,
		//				EmailAddress = objUserProfileInfo.EmailAddress,
		//				Name = objUserProfileInfo.Name,
		//				State = objUserProfileInfo.State,
		//				ZipCode = objUserProfileInfo.ZipCode,
		//				imgProfileData = objUserProfileInfo.imgProfileData
		//			};
		//			return objUserInfo;
		//		}
		//		else
		//		{
		//			return null;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}

		//public void UpdateUserProfileInfo(UserLoginProfile objUserProfileInfo)
		//{
		//	var userProfileInfo = sqliteconnection.Table<UserProfileInfo>().FirstOrDefault();

		//	userProfileInfo.Id = objUserProfileInfo.Id;
		//	userProfileInfo.Address1 = objUserProfileInfo.Address1;
		//	userProfileInfo.Address2 = objUserProfileInfo.Address2;
		//	userProfileInfo.City = objUserProfileInfo.City;
		//	userProfileInfo.Country = objUserProfileInfo.Country;
		//	userProfileInfo.EmailAddress = objUserProfileInfo.EmailAddress;
		//	userProfileInfo.Name = objUserProfileInfo.Name;
		//	userProfileInfo.State = objUserProfileInfo.State;
		//	userProfileInfo.ZipCode = objUserProfileInfo.ZipCode;
		//	userProfileInfo.imgProfileData = objUserProfileInfo.imgProfileData;
		//	sqliteconnection.Update(userProfileInfo);
		//	sqliteconnection.Update(userProfileInfo);
		//}

		//public void DeleteUserProfileInfo()
		//{
		//	try
		//	{

		//		sqliteconnection.Query<UserLoginProfile>("delete from UserProfileInfo");
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//#endregion

		//#region QRCode


		//public void SaveQRCodeInfo(QRCodeInfo objQRCodeInfo)
		//{
		//	try
		//	{
		//		sqliteconnection.Query<QRCodeInfo>("delete from QRCodeInfo");
		//		var QRCodeData = sqliteconnection.Table<QRCodeInfo>().Where(x => x.DomainUniqueKey == (objQRCodeInfo.DomainUniqueKey)).FirstOrDefault();

		//		if (QRCodeData == null)
		//		{
		//			sqliteconnection.Insert(new QRCodeInfo
		//			{
		//				DomainUniqueKey = objQRCodeInfo.DomainUniqueKey,
		//				StoreUniqueKey = objQRCodeInfo.StoreUniqueKey,
		//			});
		//		}
		//		else
		//		{
		//			QRCodeData.DomainUniqueKey = objQRCodeInfo.DomainUniqueKey;
		//			QRCodeData.StoreUniqueKey = objQRCodeInfo.StoreUniqueKey;
		//			sqliteconnection.Update(QRCodeData);
		//		}

		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//public QRCodeInfo GetQRCodeInfo()
		//{
		//	try
		//	{

		//		var QRCodeDta = sqliteconnection.Table<QRCodeInfo>().FirstOrDefault();
		//		if (QRCodeDta != null)
		//		{

		//			QRCodeInfo objQRCodeInfo = new QRCodeInfo()
		//			{
		//				DomainUniqueKey = QRCodeDta.DomainUniqueKey,
		//				StoreUniqueKey = QRCodeDta.StoreUniqueKey,
		//			};
		//			return objQRCodeInfo;
		//		}
		//		else
		//		{
		//			return null;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}

		//public void UpdateQRCodeInfo(QRCodeInfo objQRCodeInfo)
		//{
		//	var QRCodeData = sqliteconnection.Table<QRCodeInfo>().FirstOrDefault();

		//	QRCodeData.DomainUniqueKey = objQRCodeInfo.DomainUniqueKey;
		//	QRCodeData.StoreUniqueKey = objQRCodeInfo.StoreUniqueKey;
		//	sqliteconnection.Update(QRCodeData);
		//}

		//public void DeleteQRCodeInfo()
		//{
		//	try
		//	{

		//		sqliteconnection.Query<QRCodeInfo>("delete from QRCodeInfo");
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}

		//#endregion

		//#region DomainInfo

		//public void SaveDomainInfo(List<AdminDomainInfo> objDomainInfo)
		//{
		//	try
		//	{
		//		sqliteconnection.Query<DomainInfo>("delete from DomainInfo");

		//		foreach (var item in objDomainInfo)
		//		{
		//			sqliteconnection.Insert(new DomainInfo
		//			{
		//				DomainName = item.DomainName,
		//				DomainId = item.DomainId,
		//				DomainUniqueKey = item.DomainUniqueKey
		//			});
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//public List<DomainInfo> GetDomainInfo()
		//{
		//	try
		//	{
		//		var domainData = (from data in sqliteconnection.Table<DomainInfo>() select data).ToList();
		//		return domainData;

		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}

		//public void UpdateDomainInfo(List<AdminDomainInfo> objDomainInfo)
		//{
		//	var DomainData = sqliteconnection.Table<DomainInfo>().FirstOrDefault();

		//	foreach (var item in objDomainInfo)
		//	{
		//		DomainData.DomainId = item.DomainId;
		//		DomainData.DomainName = item.DomainName;
		//		DomainData.DomainUniqueKey = item.DomainUniqueKey;
		//		sqliteconnection.Update(DomainData);
		//	}
		//}

		//public void DeleteDomainInfo()
		//{
		//	try
		//	{
		//		sqliteconnection.Query<DomainInfo>("delete from DomainInfo");
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}

		//#endregion

		//#region StoreInfo

		//public void SaveStoreInfo(Storeinfo objStoreInfo)
		//{
		//	try
		//	{
		//		sqliteconnection.Query<StoreInfo>("delete from StoreInfo");
		//		var StoreData = sqliteconnection.Table<StoreInfo>().Where(x => x.StoreId == (objStoreInfo.StoreId)).FirstOrDefault();

		//		if (StoreData == null)
		//		{
		//			sqliteconnection.Insert(new StoreInfo
		//			{
		//				StoreId = objStoreInfo.StoreId,
		//				StoreUniqueKey = objStoreInfo.StoreUniqueKey,
		//				Country = objStoreInfo.Country,
		//				City = objStoreInfo.City,
		//				Address1 = objStoreInfo.Address1,
		//				Address2 = objStoreInfo.Address2,
		//				ZipCode = objStoreInfo.ZipCode,
		//				DomainUniqueKey = objStoreInfo.DomainUniqueKey,
		//				PhoneNumber = objStoreInfo.PhoneNumber,
		//				State = objStoreInfo.State,
		//				Name = objStoreInfo.Name
		//			});
		//		}
		//		else
		//		{
		//			StoreData.StoreId = objStoreInfo.StoreId;
		//			StoreData.StoreUniqueKey = objStoreInfo.StoreUniqueKey;
		//			StoreData.DomainUniqueKey = objStoreInfo.DomainUniqueKey;
		//			StoreData.State = objStoreInfo.State;
		//			StoreData.Country = objStoreInfo.Country;
		//			StoreData.City = objStoreInfo.City;
		//			StoreData.Address1 = objStoreInfo.Address1;
		//			StoreData.Address2 = objStoreInfo.Address2;
		//			StoreData.ZipCode = objStoreInfo.ZipCode;
		//			StoreData.Name = objStoreInfo.Name;
		//			sqliteconnection.Update(StoreData);
		//		}

		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//public Storeinfo GetStoreInfo()
		//{
		//	try
		//	{
		//		var StoreData = sqliteconnection.Table<StoreInfo>().FirstOrDefault();
		//		if (StoreData != null)
		//		{

		//			Storeinfo objStoreInfo = new Storeinfo()
		//			{
		//				StoreId = StoreData.StoreId,
		//				StoreUniqueKey = StoreData.StoreUniqueKey,
		//				Country = StoreData.Country,
		//				City = StoreData.City,
		//				Address1 = StoreData.Address1,
		//				Address2 = StoreData.Address2,
		//				ZipCode = StoreData.ZipCode,
		//				PhoneNumber = StoreData.PhoneNumber,
		//				Name = StoreData.Name,
		//				State = StoreData.State,
		//				DomainUniqueKey = StoreData.DomainUniqueKey
		//			};
		//			return objStoreInfo;
		//		}
		//		else
		//		{
		//			return null;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}

		//public void UpdateStoreInfo(Storeinfo objStoreInfo)
		//{
		//	var StoreData = sqliteconnection.Table<StoreInfo>().FirstOrDefault();
		//	StoreData.StoreId = objStoreInfo.StoreId;
		//	StoreData.StoreUniqueKey = objStoreInfo.StoreUniqueKey;
		//	StoreData.Country = objStoreInfo.Country;
		//	StoreData.City = objStoreInfo.City;
		//	StoreData.Address1 = objStoreInfo.Address1;
		//	StoreData.Address2 = objStoreInfo.Address2;
		//	StoreData.ZipCode = objStoreInfo.ZipCode;
		//	StoreData.DomainUniqueKey = objStoreInfo.DomainUniqueKey;
		//	StoreData.Name = objStoreInfo.Name;
		//	StoreData.PhoneNumber = objStoreInfo.PhoneNumber;
		//	StoreData.State = objStoreInfo.State;
		//	sqliteconnection.Update(StoreData);
		//}

		//public void DeleteStoreInfo()
		//{
		//	try
		//	{
		//		sqliteconnection.Query<Storeinfo>("delete from StoreInfo");
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;

		//	}
		//}

		//#endregion


		//#region #region MesuringUnitsInfo

		//public void SaveMesuringUnitsInfo(List<MeasuringUnitsListInfo> objMesuringUnitsInfo)
		//{
		//	try
		//	{
		//		sqliteconnection.Query<DomainInfo>("delete from MesuringUnitsInfo");

		//		foreach (var item in objMesuringUnitsInfo)
		//		{
		//			sqliteconnection.Insert(new MesuringUnitsInfo
		//			{
		//				Id = item.Id,
		//				LowestValue = item.LowestValue,
		//				LowestValueType = item.LowestValueType,
		//				Measurement = item.Measurement,
		//			});
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
		//}


		//public List<MesuringUnitsInfo> GetMesuringUnitsInfo()
		//{
		//	try
		//	{
		//		var MeasuringUnits = (from data in sqliteconnection.Table<MesuringUnitsInfo>() select data).ToList();
		//		return MeasuringUnits;

		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}

		//}

		//public void UpdateMesuringUnitsInfo(List<MeasuringUnitsListInfo> objMesuringUnitsInfo)
		//{
		//	var MesuringUnitsData = sqliteconnection.Table<MesuringUnitsInfo>().FirstOrDefault();

		//	foreach (var item in objMesuringUnitsInfo)
		//	{

		//		MesuringUnitsData.Id = item.Id;
		//		MesuringUnitsData.LowestValue = item.LowestValue;
		//		MesuringUnitsData.LowestValueType = item.LowestValueType;
		//		MesuringUnitsData.Measurement = item.Measurement;
		//		sqliteconnection.Update(MesuringUnitsData);
		//	}
		//}

		//public void DeleteMesuringUnitsInfo()
		//{
		//	try
		//	{
		//		sqliteconnection.Query<MeasuringUnitsListInfo>("delete from MesuringUnitsInfo");
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;

		//	}
		//}

		//#endregion


		#region IDisposable Support

		private bool disposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects).
				}

				// TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
				// TODO: set large fields to null.

				disposedValue = true;
			}
		}

		// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
		// ~DatabaseMethods() {
		//   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		//   Dispose(false);
		// }

		// This code added to correctly implement the disposable pattern.
		public void Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);
			// TODO: uncomment the following line if the finalizer is overridden above.
			// GC.SuppressFinalize(this);
		}
		#endregion
	}
}
#endregion