using GestioneSagre.Models.InputModels.Feste;
using GestioneSagre.Models.InputModels.Logo;
using GestioneSagre.Models.InputModels.Versioni;

namespace GestioneSagre.Tools.TransactionLog;

public interface ITransactionLogger
{
    Task LogTransactionVersioneCreateAsync(VersioneCreateInputModel inputModel);
    Task LogTransactionLogoEditAsync(LogoEditInputModel inputModel);
    Task LogTransactionFestaCreateAsync(FestaCreateInputModel inputModel);
    Task LogTransactionFestaEditAsync(FestaEditInputModel inputModel);
}