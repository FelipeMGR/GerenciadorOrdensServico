using AutoMapper;
using GerenciadorOrdensServico.DTO_s;
using GerenciadorOrdensServico.Models;
using GerenciadorOrdensServico.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorOrdensServico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdemServicoController : ControllerBase
    {
        private IUnityOfWork _unityOfWork;
        public IMapper _mapper;

        public OrdemServicoController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        [HttpGet("VerificarOrdens")]
        public ActionResult<ICollection<OrdemServicoDTO>> Get()
        {
            var ordens = _unityOfWork._OrdemServicoRepository.GetAll();
            if (ordens is null)
            {
                return NotFound("Ordens de serviço não encontradas.");
            }
            var ordensDTO = _mapper.Map<OrdemServicoDTO>(ordens);

            return Ok(ordensDTO);
        }

        [HttpGet("VerificarOrdens/{id}")]
        public ActionResult<OrdemServicoDTO> Get(int id)
        {
            var ordem = _unityOfWork._OrdemServicoRepository.Get(c => c.Id == id);

            if (ordem.Id != id)
            {
                return NotFound("Id inválido. Tente novamente.");
            }

            var ordemDTO = _mapper.Map<OrdemServicoDTO>(ordem);
            return Ok(ordemDTO);
        }

        [HttpPost]
        public ActionResult<OrdemServicoDTO> Create(OrdemServicoDTO ordem)
        {
            if (ordem is null)
            {
                return BadRequest("Erro ao processar a requisição. Preencha as informações corretamente.");
            }
            var novaOrdem = _mapper.Map<OrdemServico>(ordem);
            _unityOfWork._OrdemServicoRepository.Create(novaOrdem);
            _unityOfWork.Commit();

            var ordemDTO = _mapper.Map<OrdemServicoDTO>(novaOrdem);
            return new CreatedAtRouteResult("ObterOrdem", new {id =  ordemDTO.Id}, ordemDTO);
        }
    }
}
