#nullable enable

namespace DeepL
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Retrieve a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.CustomInstruction> GetCustomInstructionAsync(
            string styleId,
            string instructionId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DeepL.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DeepL.AutoSDKHttpResponse<global::DeepL.CustomInstruction>> GetCustomInstructionAsResponseAsync(
            string styleId,
            string instructionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}