using System;

namespace XianShou.bcyoo.Model.ExtendModel
{
    /// <summary>
    /// 返回信息
    /// </summary>
    [Serializable]
    public class ReturnInfoModel
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// 返回信息静态类
    /// </summary>
    public static class ReturnInfo
    {
        /// <summary>
        /// 返回成功信息
        /// </summary>
        /// <returns></returns>
        public static ReturnInfoModel Success()
        {
            return new ReturnInfoModel { IsSuccess = true, Message = string.Empty };
        }

        /// <summary>
        /// 返回成功信息
        /// </summary>
        /// <returns></returns>
        public static T Success<T>() where T : ReturnInfoModel, new()
        {
            return new T { IsSuccess = true, Message = string.Empty };
        }

        /// <summary>
        /// 返回错误信息
        /// </summary>
        /// <param name="errInfo"></param>
        /// <returns></returns>
        public static ReturnInfoModel Failure(string errInfo)
        {
            return new ReturnInfoModel { IsSuccess = false, Message = errInfo };
        }

        /// <summary>
        /// 返回错误信息
        /// </summary>
        /// <param name="errInfo"></param>
        /// <returns></returns>
        public static T Failure<T>(string errInfo) where T : ReturnInfoModel, new()
        {
            return new T { IsSuccess = false, Message = errInfo };
        }

        /// <summary>
        /// 自动判断结果到底应该返回成功还是失败
        /// </summary>
        /// <param name="result"></param>
        /// <param name="errInfo">失败的时候返回的错误信息</param>
        /// <returns></returns>
        public static ReturnInfoModel GetReturnInfo(bool result, string errInfo)
        {
            return result ? Success() : Failure(errInfo);
        }

        /// <summary>
        /// 自动判断结果到底应该返回成功还是失败
        /// </summary>
        /// <param name="result"></param>
        /// <param name="errInfo">失败的时候返回的错误信息</param>
        /// <returns></returns>
        public static T GetReturnInfo<T>(bool result, string errInfo) where T : ReturnInfoModel, new()
        {
            return result ? Success<T>() : Failure<T>(errInfo);
        }
    }

}