using LXP.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXP.Data.IRepository
{
    public interface ICourseTopicRepository
    {
        object GetAllTopicDetailsByCourseId(string courseId);
        void AddCourseTopic(Topic topic);
        bool AnyTopicByTopicName(string topicName);
        
        Topic GetTopicDetailsByTopicNameAndCourse(string topicName, Course course);

        Task<int> UpdateCourseTopic(Topic topic);
        Task<Topic> GetTopicByTopicId(Guid topicId);


    }
}
