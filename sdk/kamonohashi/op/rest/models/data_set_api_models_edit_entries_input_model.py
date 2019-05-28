# coding: utf-8

"""
    KAMONOHASHI API

    A platform for deep learning  # noqa: E501

    OpenAPI spec version: v1
    Contact: kamonohashi-support@jp.nssol.nipponsteel.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from kamonohashi.op.rest.models.data_set_api_models_create_input_model_entry import DataSetApiModelsCreateInputModelEntry  # noqa: F401,E501


class DataSetApiModelsEditEntriesInputModel(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'entries': 'dict(str, list[DataSetApiModelsCreateInputModelEntry])',
        'memo': 'str',
        'name': 'str'
    }

    attribute_map = {
        'entries': 'entries',
        'memo': 'memo',
        'name': 'name'
    }

    def __init__(self, entries=None, memo=None, name=None):  # noqa: E501
        """DataSetApiModelsEditEntriesInputModel - a model defined in Swagger"""  # noqa: E501

        self._entries = None
        self._memo = None
        self._name = None
        self.discriminator = None

        if entries is not None:
            self.entries = entries
        if memo is not None:
            self.memo = memo
        if name is not None:
            self.name = name

    @property
    def entries(self):
        """Gets the entries of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501


        :return: The entries of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501
        :rtype: dict(str, list[DataSetApiModelsCreateInputModelEntry])
        """
        return self._entries

    @entries.setter
    def entries(self, entries):
        """Sets the entries of this DataSetApiModelsEditEntriesInputModel.


        :param entries: The entries of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501
        :type: dict(str, list[DataSetApiModelsCreateInputModelEntry])
        """

        self._entries = entries

    @property
    def memo(self):
        """Gets the memo of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501


        :return: The memo of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501
        :rtype: str
        """
        return self._memo

    @memo.setter
    def memo(self, memo):
        """Sets the memo of this DataSetApiModelsEditEntriesInputModel.


        :param memo: The memo of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501
        :type: str
        """

        self._memo = memo

    @property
    def name(self):
        """Gets the name of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501


        :return: The name of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this DataSetApiModelsEditEntriesInputModel.


        :param name: The name of this DataSetApiModelsEditEntriesInputModel.  # noqa: E501
        :type: str
        """

        self._name = name

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(DataSetApiModelsEditEntriesInputModel, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, DataSetApiModelsEditEntriesInputModel):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
