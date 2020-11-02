using System;
using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Repository;
using LCMSMSPWA.enums;
using MatBlazor;

namespace LCMSMSPWA.Components
{
    public partial class OrphanAcademics
    { 
        [Parameter]
       public OrphanDetailsModel Orphan { get; set; }
       
       [Inject]
       public IAcademicRepository AcademicRepository { get; set; }
       
       protected SfConfirmDeleteDialog DeleteConfirmationDialog { get; set; }

       private ViewMode viewMode = ViewMode.List;

       private int academicIdToDelete = 0;

       private AcademicEdit academicEdit;

       private int academicIdToEdit = 0;

       private int counter = 0;

       private void OnAddClick()
       {
           viewMode = ViewMode.AddNew;
       }

       public async Task OnAddNewComplete(bool recordAdded)
       {
           viewMode = ViewMode.List;
           if (recordAdded)
           {
               Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
               StateHasChanged();
           }
       }
       
       private void OnEditClick(Academic academicRecord)
       {
           Console.WriteLine($"oneditclick: {academicRecord.AcademicID}");
           
           academicEdit = new AcademicEdit
           {
               Grade = academicRecord.Grade,
               KCPE = academicRecord.KCPE,
               KCSE = academicRecord.KCSE,
               School = academicRecord.School,
               EntryDate = academicRecord.EntryDate,
               OrphanID = academicRecord.OrphanID
           };
           academicIdToEdit = academicRecord.AcademicID;
           viewMode = ViewMode.Edit;
       }

       private async Task OnEditComplete(bool recordEdited)
       {
           academicIdToEdit = 0;
           viewMode = ViewMode.List;
           Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
           StateHasChanged();
       }

       private void OnDeleteClick(int academicId)
       {
           academicIdToDelete = academicId;
           DeleteConfirmationDialog.ShowDialog();
       }
    
       protected async Task OnConfirmDelete(bool deleteConfirmed)
       {
           if (deleteConfirmed && academicIdToDelete != 0)
           {
               await AcademicRepository.DeleteAcademicAsync(academicIdToDelete);
               Orphan.Academics = await AcademicRepository.GetOrphanAcademics(Orphan.OrphanID);
               StateHasChanged();                
           }
           academicIdToDelete = 0;
       }
    }
}
