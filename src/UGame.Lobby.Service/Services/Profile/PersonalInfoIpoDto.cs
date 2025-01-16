using UGame.Lobby.Repository.ing;
using System.Text.Json.Serialization;
using AiUo;
using AiUo.AspNet;
using AiUo.Extensions.AutoMapper;

namespace UGame.Lobby.Service.Services.Profile;

/// <summary>
/// 获取个人信息ipo
/// </summary>
public class GetPersonIpo : LobbyBaseIpo
{

}

/// <summary>
/// 
/// </summary>
public class PersonalInfoIpo : LobbyBaseIpo
{
    /// <summary>
    /// 用户昵称
    /// </summary>
    [RequiredEx("", "NickName cannot be empty.")]
    public string NickName { get; set; }

    /// <summary>
    /// FirstName
    /// </summary>
    [RequiredEx("", "FirstName cannot be empty.")]
    public string FirstName { get; set; }

    /// <summary>
    /// LastName
    /// </summary>
    [RequiredEx("", "LastName cannot be empty.")]
    public string LastName { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    [RequiredEx("", "BirthDay cannot be empty.")]
    [RegularExpressionEx("^((0([1-9]))|(1([0-9]))|(2([0-9]))|(3(0|1)))(-|/)((0([1-9]))|(1(0|1|2)))(-|/)\\d{4}$", "", "The format of ExpiryDate should be dd/MM/yyyy or dd-MM-yyyy.")]
    public string BirthDay { get; set; }

    /// <summary>
    /// 证件号
    /// </summary>
    public string IDCard { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    [RequiredEx("", "Email cannot be empty.")]
    [RegularExpressionEx("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$", "", "Illegal email format")]
    public string Email { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; }
}

public class PersonalInfoDto : IMapFrom<L_user_infoEO>
{
    /// <summary>
    /// 用户昵称
    /// </summary>
    [JsonPropertyName("NickName")]
    public string NickName { get; set; }

    /// <summary>
    /// First Name
    /// </summary>
    [JsonPropertyName("FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Last Name
    /// </summary>
    [JsonPropertyName("LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    [JsonPropertyName("BirthDay")]
    public string BirthDay { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    [JsonPropertyName("PhoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// 邮箱
    /// </summary>
    [JsonPropertyName("Email")]
    public string Email { get; set; }

    public void MapFrom(L_user_infoEO source)
    {
        if (!string.IsNullOrWhiteSpace(source.PhoneNumber))
            PhoneNumber = source.PhoneNumber.HideFixedLength(source.PhoneNumber.Length, 3, 3, '*');
        BirthDay = source.BirthDay?.ToString("dd-MM-yyyy");
    }
}

/// <summary>
/// 个人信息表单模板ipo
/// </summary>
public class PersonalInfoFormIpo : LobbyBaseIpo
{

}


public class PersonalInfoFormDto : IMapFrom<L_user_info_field_langEO>
{
    /// <summary>
    /// 对应后端的key
    /// </summary>
    public string UIFieldID { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Placeholder
    /// </summary>
    public string Placeholder { get; set; }

    /// <summary>
    /// 错误提示
    /// </summary>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// 是否必填
    /// </summary>
    public bool IsRequired { get; set; }

    /// <summary>
    /// 是否允许修改
    /// </summary>
    public bool IsAllowModify { get; set; }

    /// <summary>
    /// 数据类型
    /// 1、datetime
    /// </summary>
    public int? DBType { get; set; }

    public void MapFrom(L_user_info_field_langEO source)
    {
        IsRequired = source.IsRequired == 1;
        IsAllowModify = source.IsAllowModify == 1;
    }
}
