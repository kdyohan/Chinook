using Microsoft.AspNetCore.Mvc;
using Chinook.Application.Interface;
using Chinook.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Chinook.WebAPI.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AlbumController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<AlbumController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {

                var albumlist = await _unitOfWork.AlbumRepository.GetAll();
                return Ok(albumlist);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        // GET api/<AlbumController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {
                var existAlbum = await _unitOfWork.AlbumRepository.GetById(id);
                if (existAlbum != null)
                    return Ok(existAlbum);
                else
                    return BadRequest("Album is not available");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<AlbumController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Album entity)
        {
            try
            {
                bool isAdded = await _unitOfWork.AlbumRepository.AddEntity(entity);
                await _unitOfWork.CompleteAsync();
                if (isAdded)
                {
                    return Ok("Album is Added");
                }
                else
                {
                    return BadRequest("Someting wrong with input");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<AlbumController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] Album entity)
        {
            try
            {

                var existAlbum = await _unitOfWork.AlbumRepository.GetById(id);

                if (existAlbum != null)
                {
                    existAlbum.Id = id;
                    existAlbum.Title = entity.Title;
                    existAlbum.ArtistId = entity.ArtistId;                   
                    existAlbum.LastModified = entity.LastModified;
                    existAlbum.LastModifiedBy = entity.LastModifiedBy;

                    bool isEdited = await _unitOfWork.AlbumRepository.UpdateEntity(existAlbum);
                    await _unitOfWork.CompleteAsync();

                    if (isEdited)
                    {
                        return Ok("Album Edited syccessfuly");
                    }
                    else
                    {
                        return BadRequest("Someting wrong with input");
                    }
                }
                else
                {
                    return BadRequest("Album is not available");
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<AlbumController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                var existAlbum = await _unitOfWork.AlbumRepository.GetById(id);

                if (existAlbum != null)
                {
                    bool isDeleted = await _unitOfWork.AlbumRepository.DeleteEntity(id);
                    await _unitOfWork.CompleteAsync();
                    if (isDeleted)
                    {
                        return Ok("Album deleted syccessfuly");
                    }
                    else
                    {
                        return BadRequest("Someting wrong with input");
                    }
                }
                else
                {
                    return BadRequest("Album is not available");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
