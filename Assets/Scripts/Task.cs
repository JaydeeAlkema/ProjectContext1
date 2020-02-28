﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task : MonoBehaviour
{
	#region Variables
	private enum TaskState
	{
		Creating,
		Active,
		CountingDown,
		Done
	}     // In which state the task currently is.
	[SerializeField] private TaskState state = TaskState.Creating;  // Reference to the TaskState enum;
	[Space]
	[SerializeField] private string name = "";  // Name of the task.
	[SerializeField] private string description = "";   // Description for the task.
	[SerializeField] private float dueDateMinutes = 0;  // How many Minutes are left before the task is due.
	[SerializeField] private float dueDataHours = 0;    // How many Hours are left before the task is due.
	[SerializeField] private float dueDateDays = 0;     // How many Days are left before the task is due.
	[Space]
	[SerializeField] private Image image = default;   // The image for the task. This will be some type of food.
	[SerializeField] private TextMeshProUGUI dueDateCounter = default;  // The text element that shows the user how much time is left.
	#endregion

	#region Getters And Setters
	private TaskState State { get => state; set => state = value; }

	public string Name { get => name; set => name = value; }
	public string Description { get => description; set => description = value; }
	public float DueDateMinutes { get => dueDateMinutes; set => dueDateMinutes = value; }
	public float DueDataHours { get => dueDataHours; set => dueDataHours = value; }
	public float DueDateDays { get => dueDateDays; set => dueDateDays = value; }

	public Image Image { get => image; set => image = value; }
	public TextMeshProUGUI DueDateCounter { get => dueDateCounter; set => dueDateCounter = value; }
	#endregion

	public Task(string _name, string _description)
	{
		this.name = _name;
		this.description = _description;
	}
}
