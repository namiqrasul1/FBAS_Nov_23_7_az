#include <iostream>

using namespace std;

template<typename T>
void sort(T* arr, size_t size, bool(*compare)(T arg, T arg1)) {
	for (size_t i = 0; i < size - 1; i++)
	{
		for (size_t j = 0; j < size - 1; j++)
		{
			if (compare(arr[j], arr[j + 1]))
				swap(arr[j], arr[j + 1]);
		}
	}
}

class Person {
public:
	string name;
	int age;
	Person(string name, int age) : name(name), age(age) {}
};

bool comparePerson(Person left, Person right) {
	return left.age < right.age;
}

int main()
{
	//double* arr = new double[10] {1, 4, 245, 56, 4, 213, 2, 467, 423, 5};
	//sort(arr, 10);

	//for (size_t i = 0; i < 10; i++)
	//{
	//	cout << arr[i] << " ";
	//}

	Person* people = new Person[5]{
		Person("hakuna", 42), 
		Person("matata", 2),
		Person("John", 12),
		Person("Doe", 64), 
		Person("Kamil", 25),
	};

	sort(people, 5, comparePerson); 

	for (size_t i = 0; i < 5; i++)
	{
		cout << people[i].name << " ";
	}
}
