window.scrollToCurrentCourse = function (courseId) {
    if (!courseId) return;

    const timeline = document.getElementById("courseTimeline");
    const currentCourse = document.getElementById(`course-${courseId}`);

    if (timeline && currentCourse) {
        const timelineRect = timeline.getBoundingClientRect();
        const courseRect = currentCourse.getBoundingClientRect();

        // Scroll to center the course
        timeline.scrollBy({
            left: courseRect.left - timelineRect.left - (timelineRect.width / 2) + (courseRect.width / 2),
            behavior: "smooth"
        });
    }
};
